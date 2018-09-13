using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssRetiring : Smobiler.Core.Controls.MobileForm
    {
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private string UserId;
        private DataTable SNTable = new DataTable(); //待盘点的资产
        private static object lockobj = new object();
        private List<string> snList=new List<string>();  //资产的初始列表
        public string SOID;
        public bool IsFromSO;

        #endregion
        /// <summary>
        /// 退库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                string WareId = "";
                string STID = "";
                string SLID = "";
                if (txtSLID.Tag != null)
                {
                    string[] Ids = txtSLID.Tag.ToString().Split('/');
                    if (Ids.Length == 3)
                    {
                        WareId = Ids[0];
                        STID = Ids[1];
                        SLID = Ids[2];
                    }
                    else
                    {
                        throw new Exception("请输入正确的");
                    }
                    
                }
                else
                {
                    throw new Exception("请先选择库位！");
                }
                if (snList.Count == 0)
                {
                    throw new Exception("请添加要退库的序列号！");
                }
                ReturnInfo rInfo = new ReturnInfo();
                AssRetiringInputDto inputDto = new AssRetiringInputDto
                {
                    SOID = txtSOID.Text,
                    SLID = SLID,
                    STID = STID,
                    WAREID = WareId,
                    UserId = UserId,
                    SnList = snList
                };
                rInfo = _autofacConfig.AssSalesOrderService.RetiringAss(inputDto);
                if (rInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("退库成功！");
                    if (IsFromSO)
                    {
                        Close();
                    }
                }
                else
                {
                    Toast(rInfo.ErrorInfo);
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        
        /// <summary>
        /// 扫描序列号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelScan_Press(object sender, EventArgs e)
        {
            try
            {
                bcScanForSN.GetBarcode();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 扫描到采购单编号时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bcScanForPOID_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                string barCode = e.Value;
                bool IsExist = _autofacConfig.AssSalesOrderService.SOIDIsExist(barCode);
                if (IsExist)
                {
                    txtSOID.Text = barCode;
                    SOID = barCode;
                }
                else
                {
                    throw new Exception("请扫描正确的销售单编号");
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 扫描到库位时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bcScanForSLID_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                string barCode = e.Value;
                string WareId = "";
                string STID = "";
                string SLID = "";

                string[] Ids = barCode.Split('/');
                WareId = Ids[0];
                if (Ids.Length == 3)
                {
                    STID = Ids[1];
                    SLID = Ids[2];
                }
                else
                {
                    throw new Exception("该库位编号不存在！");
                }
                if (_autofacConfig.wareHouseService.SLIsExists(WareId, STID, SLID))
                {
                    WHStorageLocationOutputDto whLoc = _autofacConfig.wareHouseService.GetSLByID(WareId, STID, SLID);
                    if (whLoc == null) throw new Exception("库位不存在，请检查!");
                    txtSLID.Text = whLoc.WARENAME + "/" + whLoc.STNAME + "/" + whLoc.SLNAME;
                    txtSLID.Tag = barCode;
                }
                else
                {
                    throw new Exception("该库位编号不存在！");
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 扫描到序列号时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bcScanForSN_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                string barCode = e.Value;
                if (!snList.Contains(barCode))
                {
                    bool isExists = _autofacConfig.AssSalesOrderService.SNIsOK(SOID, barCode);
                    if (isExists)
                    {
                        Assets assets = _autofacConfig.SettingService.GetBySN(barCode);
                        AddSnToDataTable(barCode,assets.IMAGE);
                    }
                    else
                    {
                        throw new Exception("该序列号不在单据的销售项中！");
                    }
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 手持扫描到序列号时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000ScanForSN_BarcodeDataCaptured(object sender, Smobiler.Device.R2000BarcodeScanEventArgs e)
        {
            try
            {
                string barCode = e.Data;
                if (!snList.Contains(barCode))
                {
                    bool isExists = _autofacConfig.AssSalesOrderService.SNIsOK(SOID, barCode);
                    if (isExists)
                    {
                        Assets assets = _autofacConfig.SettingService.GetBySN(barCode);
                        AddSnToDataTable(barCode,assets.IMAGE);
                    }
                    else
                    {
                        throw new Exception("该序列号不在单据的销售项中！");
                    }
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 手持扫描到RFID时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000ScanForSN_RFIDDataCaptured(object sender, Smobiler.Device.R2000RFIDScanEventArgs e)
        {
            string RFID = e.Epc;
            if (!snList.Contains(RFID))
            {
                bool isExists = _autofacConfig.AssSalesOrderService.SNIsOK(SOID, RFID);
                if (isExists)
                {
                    Assets assets = _autofacConfig.SettingService.GetBySN(RFID);
                    AddSnToDataTable(RFID,assets.IMAGE);
                }
                else
                {

                }
            }
        }

        /// <summary>
        /// 扫描采购单编号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImgBtnForPOID_Press(object sender, EventArgs e)
        {
            try
            {
                bcScanForSOID.GetBarcode();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 扫描库位编号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImgBtnForSLID_Press(object sender, EventArgs e)
        {
            try
            {
                bcScanForSLID.GetBarcode();
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
        private void frmAssRetiring_Load(object sender, EventArgs e)
        {
            try
            {
                //添加各表格的列
                if (SNTable.Columns.Count == 0)
                {
                    SNTable.Columns.Add("SN");
                    SNTable.Columns.Add("IMAGE");
                }
                DataColumn[] keys = new DataColumn[1];
                keys[0] = SNTable.Columns["SN"];
                SNTable.PrimaryKey = keys;

                UserId = Client.Session["UserID"].ToString();
                if (!string.IsNullOrEmpty(SOID))
                {
                    txtSOID.Text = SOID;
                    ImgBtnForSOID.Visible = false;
                    txtSOID.Size = new Size(200, 30);
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
        private void frmAssRetiring_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();

            }
        }

        /// <summary>
        /// 把扫描到的资产添加到对应的Dictionary
        /// </summary>
        /// <param name="SN">序列号</param>
        private void AddSnToDataTable(string SN,string Image)
        {
            lock (lockobj)
            {
                DataRow row = SNTable.Rows.Find(SN);
                if (row == null)
                {
                    DataRow newRow = SNTable.NewRow();
                    newRow["SN"] = SN;
                    newRow["IMAGE"] = Image;
                    SNTable.Rows.Add(newRow);

                    var newdt = SNTable.Clone();
                    newdt.ImportRow(newRow);
                    snList.Add(SN);
                    lvSN.NewRow(newdt, "");
                }
            }
        }

        /// <summary>
        /// 移除序列号
        /// </summary>
        /// <param name="SN"></param>
        public void RemoveSN(string SN)
        {
            DataRow row = SNTable.Rows.Find(SN);
            if (row != null)
            {
                SNTable.Rows.Remove(row);
                snList.Remove(SN);
                lvSN.DataSource = SNTable;
                lvSN.DataBind();
            }
        }
    }
}