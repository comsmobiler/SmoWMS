using System;
using Smobiler.Core.Controls;
using SMOWMS.DTOs.OutputDTO;
using Smobiler.Device;

namespace SMOWMS.UI.MasterData
{
    /// <summary>
    /// 资产详情界面
    /// </summary>
    partial class frmAssetsDetail : Smobiler.Core.Controls.MobileForm
    {
        #region 变量
        public string AssId; //资产编号
        private string SLID; //库位编号
        private string TypeId; //类型编号
        private string ManagerId; //管理员编号
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private string LastUser; //资产最近的拥有者
        #endregion

        /// <summary>
        /// 查看处理记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLog_Press(object sender, EventArgs e)
        {
            try
            {
                frmPrShow prShow = new frmPrShow { AssId = AssId };
                Show(prShow);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 跳转到资产编辑界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Press(object sender, EventArgs e)
        {
            try
            {
                frmAssetsDetailEdit assetsDetailEdit = new frmAssetsDetailEdit { AssId = AssId};
                Show(assetsDetailEdit, (MobileForm sender1, object args) =>
                {
                    if (assetsDetailEdit.ShowResult == ShowResult.Yes)
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
                AssetsOutputDto outputDto = _autofacConfig.SettingService.GetAssetsByID(AssId);
                if (outputDto != null)
                {
                    txtEDate.Text = outputDto.ExpiryDate.ToString("yyyy-MM-dd");
                    txtAssId1.Text = outputDto.AssId;
                    txtBuyDate.Text = outputDto.BuyDate.ToString("yyyy-MM-dd");
                    txtSL.Text = outputDto.SLName;
                    txtName1.Text = outputDto.Name;
                    txtPlace1.Text = outputDto.Place;
                    txtPrice1.Text = outputDto.Price.ToString();
                    txtSN1.Text = outputDto.SN;
                    txtSPE1.Text = outputDto.Specification;
                    txtType.Text = outputDto.TypeName;
                    txtUnit1.Text = outputDto.Unit;
                    txtVendor1.Text = outputDto.Vendor;
                    image2.ResourceID = outputDto.Image;
                    txtNote1.Text = outputDto.Note;
                    SLID = outputDto.SLID;
                    TypeId = outputDto.TypeId;
                    txtATID.Text = outputDto.ATID;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 按回退时，关闭当前窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsDetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                ShowResult = ShowResult.Yes;
                Close();
            }
        }

        /// <summary>
        /// 界面初始化时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsDetail_Load(object sender, EventArgs e)
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
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Press(object sender, EventArgs e)
        {
            try
            {
                AssetsOutputDto outputDto = _autofacConfig.SettingService.GetAssetsByID(AssId);
                PosPrinterEntityCollection Commands = new PosPrinterEntityCollection();
                Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Initial));
                Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.EnabledBarcode));
                Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.AbsoluteLocation));
                Commands.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128Height, "62"));
                Commands.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128, outputDto.SN));
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
    }
}