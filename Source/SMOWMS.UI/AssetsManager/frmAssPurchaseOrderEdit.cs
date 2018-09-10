using System;
using System.Collections.Generic;
using AutoMapper;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;
using SMOWMS.UI.Layout;

namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssPurchaseOrderEdit : Smobiler.Core.Controls.MobileForm
    {
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
//        public List<AssTemplate> Templates = new List<AssTemplate>();         //选择的模板编号
        public List<AssRowInputDto> Rows = new List<AssRowInputDto>();
        public List<string> TemplateIds = new List<string>();
        private string UserId;
        private string errorInfo;
        public string POID;
        #endregion

        /// <summary>
        /// 编辑采购单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                errorInfo = "";
                if (btnDealMan.Tag == null) throw new Exception("请选择采购人！");
                if (string.IsNullOrEmpty(txtName.Text)) throw new Exception("请输入名称！");
                if (btnVendor.Tag == null) throw new Exception("请选择供应商！");
                int VId = int.Parse(btnVendor.Tag.ToString());
                GetRows();
                if (!string.IsNullOrEmpty(errorInfo))
                {
                    return;
                }
                if (Rows.Count != 0)
                {
                    AssPurchaseOrderInputDto assPurchaseOrderInput = new AssPurchaseOrderInputDto()
                    {
                        POID = txtPOID.Text,
                        PURCHASER = btnDealMan.Tag.ToString(),
                        CREATEUSER = UserId,
                        MODIFYUSER = UserId,
                        NAME = txtName.Text,
                        REALID = txtRealID.Text,
                        STATUS = 0,
                        VID = VId,
                        RowInputDtos = Rows
                    };
                    ReturnInfo returnInfo =
                        _autofacConfig.AssPurchaseOrderService.UpdatePurchaseOrderOnly(assPurchaseOrderInput);
                    if (returnInfo.IsSuccess)
                    {
                        ShowResult = ShowResult.Yes;
                        Toast("修改成功");
                        Close();
                    }
                    else
                    {
                        throw new Exception(returnInfo.ErrorInfo);
                    }
                }
                else
                {
                    throw new Exception("请添加行项！");
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 选择采购人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManager_Press(object sender, EventArgs e)
        {
            try
            {
                popMan.Groups.Clear();
                PopListGroup manGroup = new PopListGroup { Title = "采购人选择" };
                List<coreUser> users = _autofacConfig.coreUserService.GetAll();
                foreach (coreUser Row in users)
                {
                    manGroup.AddListItem(Row.USER_NAME, Row.USER_ID);
                }
                popMan.Groups.Add(manGroup);
                if (!string.IsNullOrEmpty(btnDealMan.Tag.ToString()))   //如果已有选中项，则显示选中效果
                {
                    foreach (PopListItem Item in manGroup.Items)
                    {
                        if (Item.Value == btnDealMan.Tag.ToString())
                            popMan.SetSelections(Item);
                    }
                }
                popMan.ShowDialog();

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 选择资产模板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Press(object sender, EventArgs e)
        {
            try
            {
                GetRows();
                frmAssTemplateChoose frm = new frmAssTemplateChoose { Rows = Rows };
                Show(frm, (MobileForm sender1, object args) =>
                {
                    if (frm.ShowResult == ShowResult.Yes)
                    {
                        //重新加载数据
                        Rows = frm.Rows;
                        Bind();
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 扫描资产模板编号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void betGet_Press(object sender, EventArgs e)
        {
            bsAss.GetBarcode();
        }

        /// <summary>
        /// 扫描到资产模板编号时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bsAss_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(e.error))
                {
                    String templateId = e.Value;
                    AssTemplate assTemplate = _autofacConfig.SettingService.GetAtbyId(templateId);
                    if (assTemplate != null)
                    {
                        if (TemplateIds.Contains(templateId))
                        {
                            throw new Exception("该模板已添加，请勿重复添加!");

                        }
                        else
                        {
                            TemplateIds.Add(templateId);
                            decimal price = 0;
                            if (assTemplate.PRICE != null)
                            {
                                price = assTemplate.PRICE.Value;
                            }
                            AssRowInputDto rowInputDto = new AssRowInputDto
                            {
                                TEMPLATEID = templateId,
                                QUANT = 0,
                                PRICE = 0,
                                TPRICE = price,
                                IMAGE = assTemplate.IMAGE,
                                NAME = assTemplate.NAME
                            };
                            Rows.Add(rowInputDto);
                            Bind();
                        }
                    }
                    else
                    {
                        throw new Exception("编号为" + templateId + "模板不存在，请检查!");
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 选中采购人时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popDealMan_Selected(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(popMan.Selection.Text) == false)
            {
                btnDealMan.Text = popMan.Selection.Text + "   > ";
                btnDealMan.Tag = popMan.Selection.Value;         //采购人编号
            }
        }

        /// <summary>
        /// 数据加载
        /// </summary>
        public void Bind()
        {
            try
            {
                if (Rows.Count > 0)
                {
                    ListATs.DataSource = Rows;
                    ListATs.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 删除当前选择行项
        /// </summary>
        /// <param name="TemlateID">模板编号</param>
        public void RemoveTemplate(String TemlateID)
        {
            foreach (AssRowInputDto row in Rows)
            {
                if (row.TEMPLATEID == TemlateID)
                {
                    Rows.Remove(row);
                    break;
                }
            }
            Bind();       //刷新当前页面
        }

        /// <summary>
        /// 得到行项数据
        /// </summary>
        public void GetRows()
        {
            try
            {
                foreach (ListViewRow Row in ListATs.Rows)
                {
                    frmAssPORowLayout layout = Row.Control as frmAssPORowLayout;
                    if (layout != null)
                    {
                        AssRowInputDto rowInputDto = Rows.Find(a => a.TEMPLATEID == layout.LblTId.Text);
                        rowInputDto.QUANT = (decimal)layout.numQuant.Value;
                        rowInputDto.PRICE = (decimal)layout.numPrice.Value;
                        if (rowInputDto.QUANT == 0 || rowInputDto.PRICE == 0)
                        {
                            errorInfo = "请保证行项中的数量和单价均不为0！";
                            throw new Exception("请保证行项中的数量和单价均不为0！");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 界面初始化时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssPurchaseOrderEdit_Load(object sender, EventArgs e)
        {
            try
            {
                UserId = Client.Session["UserID"].ToString();
                var asspo = _autofacConfig.AssPurchaseOrderService.GetById(POID);
                if (asspo != null)
                {
                    txtPOID.Text = POID;
                    txtName.Text = asspo.NAME;
                    txtRealID.Text = asspo.REALID;
                    btnDealMan.Tag = asspo.PURCHASER;
                    btnDealMan.Text=asspo.PURCHASERNAME + "   > ";
                    btnVendor.Tag = asspo.VID;
                    btnVendor.Text=asspo.VNAME + "   > ";
                }
                var assporow = _autofacConfig.AssPurchaseOrderService.GetPORows(POID);
                if (assporow != null)
                {
                    Rows = Mapper.Map<List<AssPORowOutputDto>, List<AssRowInputDto>>(assporow);
                    ListATs.DataSource = Rows;
                    ListATs.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 按回退，则关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssPurchaseOrderEdit_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
        }

        private void btnVendor_Press(object sender, EventArgs e)
        {
            try
            {
                popVendor.Groups.Clear();
                PopListGroup vendorGroup = new PopListGroup { Title = "供应商选择" };
                List<Vendor> vendors = _autofacConfig.vendorService.GetAll();
                foreach (Vendor Row in vendors)
                {
                    vendorGroup.AddListItem(Row.NAME, Row.VID.ToString());
                }
                popVendor.Groups.Add(vendorGroup);
                if (btnVendor.Tag != null)   //如果已有选中项，则显示选中效果
                {
                    foreach (PopListItem Item in vendorGroup.Items)
                    {
                        if (Item.Value == btnVendor.Tag.ToString())
                            popVendor.SetSelections(Item);
                    }
                }
                popVendor.ShowDialog();

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void popVendor_Selected(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(popVendor.Selection.Text) == false)
            {
                btnVendor.Text = popVendor.Selection.Text + "   > ";
                btnVendor.Tag = popVendor.Selection.Value;         //采购人编号
            }
        }
    }
}