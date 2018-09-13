using System;
using Smobiler.Core.Controls;
using Smobiler.Device;
using SMOWMS.CommLib;
using SMOWMS.UI.ConsumablesManager;

namespace SMOWMS.UI.MasterData
{
    partial class frmConsumablesDetail : Smobiler.Core.Controls.MobileForm
    {
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public string CID;  //耗材编号
        #endregion

        /// <summary>
        /// 查看耗材库存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuant_Press(object sender, EventArgs e)
        {
            try
            {
                frmConQuant conQuant = new frmConQuant {CID = CID};
                Show(conQuant);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 编辑耗材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Press(object sender, EventArgs e)
        {
            try
            {
                frmConsumablesDetailEdit conEdit = new frmConsumablesDetailEdit() { CID = CID };
                Form.Show(conEdit, (MobileForm sender1, object args) =>
                {
                    if (conEdit.ShowResult == ShowResult.Yes)
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
        /// 按回退键，关闭当前窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConsumablesDetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
                
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConsumablesDetail_Load(object sender, EventArgs e)
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
        /// <summary>
        /// 耗材条码打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Press(object sender, EventArgs e)
        {
            try
            {
                PosPrinterEntityCollection Commands = new PosPrinterEntityCollection();
                Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Initial));
                Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.EnabledBarcode));
                Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.AbsoluteLocation));
                Commands.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128Height, "62"));
                Commands.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128, CID));
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
        }
        /// <summary>
        /// 删除耗材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Press(object sender, EventArgs e)
        {
            try
            {
                ReturnInfo returnInfo = _autofacConfig.consumablesService.DeleteConsumables(CID);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("删除成功.");
                    Close();
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
    }
}