using System;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.UI.Layout;

namespace SMOWMS.UI.MasterData
{
    partial class frmAssTemplateCreate : Smobiler.Core.Controls.MobileForm
    {
        #region 变量
        public string UserId; //用户名
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
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
                if (btnType.Tag==null)
                {
                    throw new Exception("请选择类别.");
                }
                decimal? price=null;

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
                    IMAGE = ImgPicture.ResourceID,
                    NAME = txtName.Text,
                    NOTE = txtNote.Text,
                    PRICE = price,
                    SPECIFICATION = txtSpe.Text,
                    TYPEID = btnType.Tag.ToString(),
                    UNIT = txtUnit.Text,
                    VENDOR = txtVendor.Text
                };
                ReturnInfo returnInfo = _autofacConfig.SettingService.AddAssTemplate(assTemplateInputDto);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Close();
                    Toast("添加成功.资产模板编号为" + returnInfo.ErrorInfo);
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
            ShowDialog(tree, GetType);
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
        /// 按回退时，关闭当前窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssTemplateCreate_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Close();
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssTemplateCreate_Load(object sender, EventArgs e)
        {
            try
            {
                if (btnType.Tag != null)
                {
                    var type = _autofacConfig.assTypeService.GetByID(btnType.Tag.ToString());
                    btnType.Text = type.NAME;
                }
                UserId = Client.Session["UserID"].ToString();
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