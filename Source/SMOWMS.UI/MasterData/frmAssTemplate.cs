using System;
using System.Collections.Generic;
using System.Data;
using Smobiler.Core.Controls;
using Smobiler.Device;
using SMOWMS.Domain.Entity;

namespace SMOWMS.UI.MasterData
{
    partial class frmAssTemplate : Smobiler.Core.Controls.MobileForm
    {
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        public string SelectTemplateId;  //当前选择的模板
        private string Type;        //资产大类
        #endregion

        /// <summary>
        /// 手机扫描二维码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageButton1_Press(object sender, EventArgs e)
        {
            try
            {
                barcodeScanner1.GetBarcode();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 按照TemplateId或者名称模糊匹配查询资产模板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFactor_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        /// <summary>
        /// 选择资产大类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tpSearch_Press(object sender, EventArgs e)
        {
            try
            {
                popType.Groups.Clear();       //数据清空
                PopListGroup poli = new PopListGroup();
                poli.AddListItem("全部", "");
                popType.Groups.Add(poli);
                List<AssetsType> types = _autofacConfig.assTypeService.GetAllFirstLevel();
                foreach (AssetsType Row in types)
                {
                    poli.AddListItem(Row.NAME, Row.TYPEID);
                }
                if (Type != null)   //如果已有选中项，则显示选中效果
                {
                    foreach (PopListItem Item in poli.Items)
                    {
                        if (Item.Value == Type)
                            popType.SetSelections(Item);
                    }
                }
                popType.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 选择了资产大类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popType_Selected(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(popType.Selection.Text) == false)
            {
                if (String.IsNullOrEmpty(Type))
                {
                    Type = popType.Selection.Value;         //调入管理员编号
                    SearchData();
                }
                else if (popType.Selection.Value != Type)
                {
                    Type = popType.Selection.Value;         //调入管理员编号
                    SearchData();
                }
            }
        }

        private void barcodeScanner1_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                string barCode = e.Value;
                DataTable table = _autofacConfig.SettingService.QueryAssTemplates(barCode, Type);
                gridAssRows.Cells.Clear();
                table.Columns.Add("IsChecked");
                foreach (DataRow Row in table.Rows)
                {
                    if (Row["TEMPLATEID"].ToString() == SelectTemplateId)
                    {
                        Row["IsChecked"] = true;
                    }
                    else
                    {
                        Row["IsChecked"] = false;
                    }
                }
                if (table.Rows.Count > 0)
                {
                    gridAssRows.DataSource = table;
                    gridAssRows.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void r2000Scanner1_BarcodeDataCaptured(object sender, Smobiler.Device.R2000BarcodeScanEventArgs e)
        {
            try
            {
                string barCode = e.Data;
                DataTable table = _autofacConfig.SettingService.QueryAssTemplates(barCode, Type);
                gridAssRows.Cells.Clear();
                table.Columns.Add("IsChecked");
                foreach (DataRow Row in table.Rows)
                {
                    if (Row["TEMPLATEID"].ToString() == SelectTemplateId)
                    {
                        Row["IsChecked"] = true;
                    }
                    else
                    {
                        Row["IsChecked"] = false;
                    }
                }
                if (table.Rows.Count > 0)
                {
                    gridAssRows.DataSource = table;
                    gridAssRows.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 手持物理按键扫描RFID，扫描到RFID信息时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000Scanner1_RFIDDataCaptured(object sender, Smobiler.Device.R2000RFIDScanEventArgs e)
        {
            try
            {
                string RFID = e.Epc;
                DataTable table = _autofacConfig.SettingService.QueryAssTemplates(RFID, Type);
                gridAssRows.Cells.Clear();
                table.Columns.Add("IsChecked");
                foreach (DataRow Row in table.Rows)
                {
                    if (Row["TEMPLATEID"].ToString() == SelectTemplateId)
                    {
                        Row["IsChecked"] = true;
                    }
                    else
                    {
                        Row["IsChecked"] = false;
                    }
                }
                if (table.Rows.Count > 0)
                {
                    gridAssRows.DataSource = table;
                    gridAssRows.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssTemplate_Load(object sender, EventArgs e)
        {
            try
            {
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        public void Bind()
        {
            try
            {

                DataTable table = _autofacConfig.SettingService.GetAllTemplate();
                gridAssRows.Cells.Clear();
                table.Columns.Add("IsChecked");
                foreach (DataRow Row in table.Rows)
                {
                    if (Row["TEMPLATEID"].ToString() == SelectTemplateId)
                    {
                        Row["IsChecked"] = true;
                    }
                    else
                    {
                        Row["IsChecked"] = false;
                    }
                }
                if (table.Rows.Count > 0)
                {
                    gridAssRows.DataSource = table;
                    gridAssRows.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 点击ActionButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssTemplate_ActionButtonPress(object sender, ActionButtonPressEventArgs e)
        {
            try
            {
                switch (e.Index)
                {
                    case 0:     //模板新增
                        try
                        {
                            frmAssTemplateCreate assTemplateCreate = new frmAssTemplateCreate();
                            Show(assTemplateCreate, (MobileForm sender1, object args) =>
                                {
                                    if (assTemplateCreate.ShowResult == ShowResult.Yes)
                                    {
                                        Bind();
                                    }

                                }
                            );
                        }
                        catch (Exception ex)
                        {
                            Toast(ex.Message);
                        }
                        break;
                    case 1:
                        //模板复制
                        try
                        {
                            if (string.IsNullOrEmpty(SelectTemplateId))
                            {
                                throw new Exception("请先选择模板.");
                            }
                            var assTemplate = _autofacConfig.SettingService.GetAtbyId(SelectTemplateId);

                            frmAssTemplateCreate assTemplateCreate = new frmAssTemplateCreate
                            {
                                ImgPicture = { ResourceID = assTemplate.IMAGE },
                                txtName = { Text = assTemplate.NAME },
                                txtNote = { Text = assTemplate.NOTE },
                                txtPrice = { Text = assTemplate.PRICE.ToString() },
                                txtSpe = { Text = assTemplate.SPECIFICATION },
                                btnType = { Text = assTemplate.TYPEID,Tag = assTemplate.TYPEID},
                                txtUnit = { Text = assTemplate.UNIT },
                                txtVendor = { Text = assTemplate.VENDOR }
                            };

                            Show(assTemplateCreate, (MobileForm sender1, object args) =>
                                {
                                    if (assTemplateCreate.ShowResult == ShowResult.Yes)
                                    {
                                        Bind();
                                    }

                                }
                            );
                        }
                        catch (Exception ex)
                        {
                            Toast(ex.Message);
                        }
                        break;
                    case 2:
                        //打印标签
                        try
                        {
                            if (string.IsNullOrEmpty(SelectTemplateId))
                            {
                                throw new Exception("请先选择模板.");
                            }
                            AssTemplate outputDto = _autofacConfig.SettingService.GetAtbyId(SelectTemplateId);
                            PosPrinterEntityCollection Commands = new PosPrinterEntityCollection();
                            Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Initial));
                            Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.EnabledBarcode));
                            Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.AbsoluteLocation));
                            Commands.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128Height, "62"));
                            Commands.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128, outputDto.TEMPLATEID));
                            //Commands.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128, "E2000017320082231027BD"));
                            Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.DisabledBarcode));
                            Commands.Add(new PosPrinterContentEntity(System.Environment.NewLine));
                            Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Cut));

                            posPrinter1.Print(Commands, (obj, args) =>
                            {
                                if (args.isError == true)
                                    this.Toast("Error: " + args.error);
                                else
                                    this.Toast("打印成功");
                            });
                        }
                        catch (Exception ex)
                        {
                            Toast(ex.Message);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void SearchData()
        {
            try
            {
                DataTable table = _autofacConfig.SettingService.QueryAssTemplates(txtNote.Text, Type);
                gridAssRows.Cells.Clear();
                table.Columns.Add("IsChecked");
                foreach (DataRow Row in table.Rows)
                {
                    if (Row["TEMPLATEID"].ToString() == SelectTemplateId)
                    {
                        Row["IsChecked"] = true;
                    }
                    else
                    {
                        Row["IsChecked"] = false;
                    }
                }
                if (table.Rows.Count > 0)
                {
                    gridAssRows.DataSource = table;
                    gridAssRows.DataBind();
                }
            }

            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}