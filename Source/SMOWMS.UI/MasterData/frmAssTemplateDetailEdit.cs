using System;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.UI.Layout;

namespace SMOWMS.UI.MasterData
{
    partial class frmAssTemplateDetailEdit : Smobiler.Core.Controls.MobileForm
    {
        #region 变量
        AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public string TempId;  //资产模板编号
        public string UserId; //用户名
        private AssetTypeTree tree = new AssetTypeTree();
        #endregion

        /// <summary>
        /// 添加资产模板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (btnType.Tag == null)
                {
                    throw new Exception("请选择类别.");
                }
                decimal? price = null;

                if (!string.IsNullOrEmpty(txtPrice.Text))
                {
                    decimal p2;
                    if (!decimal.TryParse(txtPrice.Text, out p2))
                    {
                        throw new Exception("请输入正确的价格.");
                    }
                    else
                    {
                        price = p2;
                    }
                }
                AssTemplateInputDto assTemplateInputDto = new AssTemplateInputDto
                {
                    TEMPLATEID = TempId,
                    IMAGE = ImgPicture.ResourceID,
                    NAME = txtName.Text,
                    NOTE = txtNote.Text,
                    PRICE = price,
                    SPECIFICATION = txtSpe.Text,
                    TYPEID = btnType.Tag.ToString(),
                    UNIT = txtUnit.Text,
                    VENDOR = txtVendor.Text
                };
                ReturnInfo returnInfo = _autofacConfig.SettingService.UpdateAssTemplate(assTemplateInputDto);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Close();
                    Toast("修改成功.");
                }
                else
                {
                    Toast(returnInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


        /// <summary>
        /// 选择类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnType_Press(object sender, EventArgs e)
        {
            try
            {
                ShowDialog(tree, GetType);

                //                PopType.Groups.Clear();
                //                PopListGroup typeGroup = new PopListGroup();
                //                typeGroup.Title = "资产类型";
                //                var typelist = _autofacConfig.assTypeService.GetAll();
                //                foreach (var type in typelist)
                //                {
                //                    PopListItem item = new PopListItem
                //                    {
                //                        Value = type.TYPEID,
                //                        Text = type.NAME
                //                    };
                //                    typeGroup.Items.Add(item);
                //                }
                //                PopType.Groups.Add(typeGroup);
                //                if (!string.IsNullOrEmpty(btnType.Text))
                //                {
                //                    foreach (PopListItem row in PopType.Groups[0].Items)
                //                    {
                //                        if (row.Text == btnType.Text)
                //                        {
                //                            PopType.SetSelections(row);
                //                        }
                //                    }
                //                }
                //                PopType.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelImg_Press(object sender, EventArgs e)
        {
            CamPicture.GetPhoto();
        }

        /// <summary>
        /// 按回退时，关闭当前窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssTemplateDetailEdit_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Close();
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssTemplateDetailEdit_Load(object sender, EventArgs e)
        {
            try
            {

                UserId = Session["UserID"].ToString();
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
        private void Bind()
        {

            try
            {
                AssTemplate outputDto = _autofacConfig.SettingService.GetAtbyId(TempId);
                if (outputDto != null)
                {
                    txtAssID.Text = outputDto.TEMPLATEID;
                    txtName.Text = outputDto.NAME;
                    txtPrice.Text = outputDto.PRICE.ToString();
                    txtSpe.Text = outputDto.SPECIFICATION;
                    txtUnit.Text = outputDto.UNIT;
                    txtVendor.Text = outputDto.VENDOR;
                    ImgPicture.ResourceID = outputDto.IMAGE;
                    txtNote.Text = outputDto.NOTE;
                    var type = _autofacConfig.assTypeService.GetByID(outputDto.TYPEID);
                    btnType.Text = type.NAME;
                    btnType.Tag = outputDto.TYPEID;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 类型选中后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopType_Selected(object sender, EventArgs e)
        {
            try
            {
                if (PopType.Selection == null) return;
                btnType.Text = PopType.Selection.Text;
                btnType.Tag = PopType.Selection.Value;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 图片获取到后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CamPicture_ImageCaptured(object sender, BinaryResultArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(e.error))
                {
                    e.SaveFile(UserId + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png");
                    ImgPicture.ResourceID = UserId + DateTime.Now.ToString("yyyyMMddHHmmss");
                    ImgPicture.Refresh();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        public void GetType(object sender, EventArgs e)
        {
            btnType.Tag = tree.ID;
            btnType.Text = tree.TypeName;
        }
    }
}