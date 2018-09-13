using System;
using System.Data;
using Smobiler.Core.Controls;
using Smobiler.Device;
using SMOWMS.DTOs.OutputDTO;
using SMOWMS.Domain.Entity;
using System.Collections.Generic;
using SMOWMS.UI.AssetsManager;

namespace SMOWMS.UI.MasterData
{

    /// <summary>
    /// 资产列表界面
    /// </summary>
    partial class frmAssets : Smobiler.Core.Controls.MobileForm
    {
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        public string SelectAssId;  //当前选择的资产
        private string Type;        //资产大类
        private string UserId;
        internal String wareId;    //所选仓库编号
        #endregion
        /// <summary>
        /// 绑定数据
        /// </summary>
        public void Bind()
        {
            try
            {
                DataTable table = _autofacConfig.SettingService.GetAllAss(wareId);
                gridAssRows.Cells.Clear();
                table.Columns.Add("IsChecked");
                foreach (DataRow Row in table.Rows)
                {
                    if (Row["AssId"].ToString() == SelectAssId)
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
        private void frmAssets_Load(object sender, EventArgs e)
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
        /// 手持物理按键扫二维码，扫描到数据时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000Scanner1_BarcodeDataCaptured(object sender, Smobiler.Device.R2000BarcodeScanEventArgs e)
        {
            try
            {
                string barCode = e.Data;
                DataTable table = _autofacConfig.SettingService.QueryAssets(barCode,Type);
                gridAssRows.Cells.Clear();
                table.Columns.Add("IsChecked");
                foreach (DataRow Row in table.Rows)
                {
                    if (Row["AssId"].ToString() == SelectAssId)
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
        private void r2000Scanner1_RFIDDataCaptured(object sender, R2000RFIDScanEventArgs e)
        {
            try
            {
                string RFID = e.Epc;
                DataTable table = _autofacConfig.SettingService.QueryAssets(RFID,Type);
                gridAssRows.Cells.Clear();
                table.Columns.Add("IsChecked");
                foreach (DataRow Row in table.Rows)
                {
                    if (Row["AssId"].ToString() == SelectAssId)
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
        private void frmAssets_ActionButtonPress(object sender, ActionButtonPressEventArgs e)
        {

            try
            {
                switch (e.Index)
                {
                    case 0:     //资产调拨
                        //调拨
                        frmAssTransferRows frmT = new frmAssTransferRows();
                        this.Form.Show(frmT);
                        break;
                    case 1:
                        //资产打印
                        try
                        {
                            if (string.IsNullOrEmpty(SelectAssId))
                            {
                                throw new Exception("请先选择资产.");
                            }
                            AssetsOutputDto outputDto = _autofacConfig.SettingService.GetAssetsByID(SelectAssId);
                            PosPrinterEntityCollection Commands = new PosPrinterEntityCollection();
                            Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Initial));
                            Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.EnabledBarcode));
                            Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.AbsoluteLocation));
                            Commands.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128Height, "62"));
                            Commands.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128, outputDto.SN));
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

        /// <summary>
        /// 手机二维码扫描到二维码信息时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barcodeScanner1_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                string barCode = e.Value;
                DataTable table = _autofacConfig.SettingService.QueryAssets(barCode, Type);
                gridAssRows.Cells.Clear();
                table.Columns.Add("IsChecked");
                foreach (DataRow Row in table.Rows)
                {
                    if (Row["AssId"].ToString() == SelectAssId)
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
                    label1.Text = popType.Selection.Text+ "▼";
                    SearchData();
                }
                else if (popType.Selection.Value != Type)
                {
                    Type = popType.Selection.Value;         //调入管理员编号
                    label1.Text = popType.Selection.Text + "▼";
                    SearchData();
                }
            }
        }
        /// <summary>
        /// 按照SN或者名称模糊匹配查询资产
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFactor_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }
        private void SearchData()
        {
            try
            {
                DataTable table = _autofacConfig.SettingService.QueryAssets(txtNote.Text, Type);
                gridAssRows.Cells.Clear();
                table.Columns.Add("IsChecked");
                foreach (DataRow Row in table.Rows)
                {
                    if (Row["AssId"].ToString() == SelectAssId)
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
    }
}