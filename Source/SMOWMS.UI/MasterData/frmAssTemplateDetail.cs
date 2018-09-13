using System;
using Smobiler.Core.Controls;
using SMOWMS.Domain.Entity;

namespace SMOWMS.UI.MasterData
{
    partial class frmAssTemplateDetail : Smobiler.Core.Controls.MobileForm
    {
        #region 变量
        public string TempId; //资产编号
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private string typeId;
        #endregion


        /// <summary>
        /// 跳转到资产模板编辑界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Press(object sender, EventArgs e)
        {
            try
            {
                frmAssTemplateDetailEdit assTemplateDetailEdit = new frmAssTemplateDetailEdit { TempId = lblTempID.Text};
                Show(assTemplateDetailEdit, (MobileForm sender1, object args) =>
                {
                    if (assTemplateDetailEdit.ShowResult == ShowResult.Yes)
                    {
                        ShowResult = ShowResult.Yes;
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
        /// 绑定数据
        /// </summary>
        private void Bind()
        {

            try
            {
                AssTemplate outputDto = _autofacConfig.SettingService.GetAtbyId(TempId);
                if (outputDto != null)
                {
                    lblTempID.Text = outputDto.TEMPLATEID;
                    lblName.Text = outputDto.NAME;
                    lblPrice.Text = outputDto.PRICE.ToString();
                    lblSpe.Text = outputDto.SPECIFICATION;
                    lblUnit.Text = outputDto.UNIT;
                    lblVendor.Text = outputDto.VENDOR;
                    ImgPicture.ResourceID = outputDto.IMAGE;
                    lblNote.Text = outputDto.NOTE;
                    var type = _autofacConfig.assTypeService.GetByID(outputDto.TYPEID);
                    lblType.Text = type.NAME;

                }
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
        private void frmAssTemplateDetail_KeyDown(object sender, KeyDownEventArgs e)
        {

            if (e.KeyCode == KeyCode.Back)
            {
                ShowResult = ShowResult.Yes;
                Close();
            }
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssTemplateDetail_Load(object sender, EventArgs e)
        {
            Bind();
        }
    }
}