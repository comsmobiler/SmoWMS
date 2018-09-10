using System;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.DTOs.InputDTO;

namespace SMOWMS.UI.MasterData
{
    partial class frmConsumablesDetailEdit : Smobiler.Core.Controls.MobileForm
    {
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public string CID;  //耗材编号
        public string UserId;   //用户编号
        

        #endregion

        /// <summary>
        /// 保存修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                //判断有效性
                int? Ceiling = null;
                if (!string.IsNullOrEmpty(txtCeiling.Text))
                {
                    int result;
                    if (int.TryParse(txtCeiling.Text, out result))
                    {
                        Ceiling = result;
                    }
                    else
                    {
                        throw new Exception("请输入正确的安全库存上限.");
                    }
                }
                int? Floor = null;
                if (!string.IsNullOrEmpty(txtFloor.Text))
                {
                    int result;
                    if (int.TryParse(txtFloor.Text, out result))
                    {
                        Floor = result;
                    }
                    else
                    {
                        throw new Exception("请输入正确的安全库存下限.");
                    }
                }
                int? SPQ = null;
                if (!string.IsNullOrEmpty(txtSPQ.Text))
                {
                    int result;
                    if (int.TryParse(txtSPQ.Text, out result))
                    {
                        SPQ = result;
                    }
                    else
                    {
                        throw new Exception("请输入正确的标准包装数量.");
                    }
                }
                ConsumablesInputDto consumablesInputDto = new ConsumablesInputDto()
                {
                    CID = CID,
                    CREATEUSER = UserId,
                    IMAGE = ImgPicture.ResourceID,
                    MODIFYUSER = UserId,
                    NAME = txtName.Text,
                    NOTE = txtNote.Text,
                    SAFECEILING = Ceiling,
                    SAFEFLOOR = Floor,
                    SPECIFICATION = txtSpe.Text,
                    SPQ = SPQ,
                    UNIT = txtUnit.Text
                };
                ReturnInfo returnInfo = _autofacConfig.consumablesService.UpdateConsumables(consumablesInputDto);
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
        /// 上传图片时
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
        private void frmConsumablesDetailEdit_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Close();
        }

        /// <summary>
        /// 获得需上传的图片数据时
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
        /// 初始化界面时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConsumablesDetailEdit_Load(object sender, EventArgs e)
        {
            try
            {
                UserId = Client.Session["UserID"].ToString();
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void Bind()
        {
            try
            {
                var consumables = _autofacConfig.consumablesService.GetConsById(CID);
                txtAssID.Text = consumables.CID;
                txtCeiling.Text = consumables.SAFECEILING.ToString();
                txtFloor.Text = consumables.SAFEFLOOR.ToString();
                txtName.Text = consumables.NAME;
                txtNote.Text = consumables.NOTE;
                txtSPQ.Text = consumables.SPQ.ToString();
                txtSpe.Text = consumables.SPECIFICATION;
                txtUnit.Text = consumables.UNIT;
                ImgPicture.ResourceID = consumables.IMAGE;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}