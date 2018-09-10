using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.UI.Layout;
using ListView = Smobiler.Core.Controls.ListView;

namespace SMOWMS.UI.AssetsManager
{
    /// <summary>
    /// 盘点单详情
    /// </summary>
    partial class frmAssInventoryResult : Smobiler.Core.Controls.MobileForm
    {
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public string IID; //盘点单编号
        private string UserId;  //用户编号
        private DataTable waiTable = new DataTable(); //待盘点的资产
        private DataTable alreadyTable = new DataTable(); //已盘点的资产
        private Dictionary<string, int> assDictionary = new Dictionary<string, int>();  //资产
        private List<string> assList;  //资产的初始列表
        //private List<string> RFIDlist;    //RFID的扫描数据集合

        private ListView waitListView = new ListView();
        private ListView alreadyListView = new ListView();

        public string WAREID;
        public string STID;
        public string SLID;
        public string typeId;
        public string DepartmentId;
        public InventoryStatus Status;
        private DataTable allAssTable = new DataTable(); //全部资产
        #endregion

        /// <summary>
        /// 初始化界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssInventoryResult_Load(object sender, EventArgs e)
        {
            try
            {
                //添加各表格的列
                if (waiTable.Columns.Count == 0)
                {

                    waiTable.Columns.Add("RESULTNAME");
                    waiTable.Columns.Add("ASSID");
                    waiTable.Columns.Add("Image");
                    waiTable.Columns.Add("SLName");
                    waiTable.Columns.Add("Name");
                    waiTable.Columns.Add("Price");
                    waiTable.Columns.Add("SN");
                    waiTable.Columns.Add("TypeName");
                    waiTable.Columns.Add("Specification");


                }
                DataColumn[] keys = new DataColumn[1];
                keys[0] = waiTable.Columns["ASSID"];
                waiTable.PrimaryKey = keys;

                //添加各表格的列
                if (alreadyTable.Columns.Count == 0)
                {

                    alreadyTable.Columns.Add("RESULTNAME");
                    alreadyTable.Columns.Add("ASSID");
                    alreadyTable.Columns.Add("Image");
                    alreadyTable.Columns.Add("SLName");
                    alreadyTable.Columns.Add("Name");
                    alreadyTable.Columns.Add("Price");
                    alreadyTable.Columns.Add("SN");
                    alreadyTable.Columns.Add("TypeName");
                    alreadyTable.Columns.Add("Specification");
                }
                DataColumn[] keys2 = new DataColumn[1];
                keys2[0] = alreadyTable.Columns["ASSID"];
                alreadyTable.PrimaryKey = keys2;

                UserId = Client.Session["UserID"].ToString();
//                UserId = "12345678912";

                //添加各表格的列
                if (allAssTable.Columns.Count == 0)
                {

                    //                    allAssTable.Columns.Add("RESULTNAME");
                    allAssTable.Columns.Add("ASSID");
                    allAssTable.Columns.Add("Image");
                    allAssTable.Columns.Add("SLName");
                    allAssTable.Columns.Add("Name");
                    allAssTable.Columns.Add("Price");
                    allAssTable.Columns.Add("SN");
                    allAssTable.Columns.Add("TypeName");
                    allAssTable.Columns.Add("Specification");


                }
                DataColumn[] keys3 = new DataColumn[1];
                keys[0] = allAssTable.Columns["SN"];
                allAssTable.PrimaryKey = keys;

                allAssTable.Rows.Clear();
                waiTable.Rows.Clear();
                alreadyTable.Rows.Clear();

                var allAssTable1 = _autofacConfig.SettingService.GetAllAss(null);
                foreach (DataRow row in allAssTable1.Rows)
                {
                    DataRow Row = allAssTable.NewRow();
                    Row["ASSID"] = row["ASSID"].ToString();
                    Row["Image"] = row["Image"].ToString();
                    Row["SLName"] = row["SLName"].ToString();
                    Row["Name"] = row["Name"].ToString();
                    Row["Price"] = row["Price"].ToString();
                    Row["SN"] = row["SN"].ToString();
                    Row["TypeName"] = row["TypeName"].ToString();
                    Row["Specification"] = row["Specification"].ToString();


                    allAssTable.Rows.Add(Row);
                }


                //添加ListView到tabpageview
                waitListView.TemplateControlName = "frmAIResultLayout";
                waitListView.ShowSplitLine = true;
                waitListView.SplitLineColor = Color.FromArgb(230, 230, 230);
                waitListView.Dock = DockStyle.Fill;
                tabPageView1.Controls.Add(waitListView);

                alreadyListView.TemplateControlName = "frmAIResultLayout";
                alreadyListView.ShowSplitLine = true;
                alreadyListView.SplitLineColor = Color.FromArgb(230, 230, 230);
                alreadyListView.Dock = DockStyle.Fill;
                tabPageView1.Controls.Add(alreadyListView);

                var inventory = _autofacConfig.AssInventoryService.GetAssInventoryById(IID);
                txtName.Text = inventory.NAME;
                txtHandleMan.Text = inventory.HANDLEMANNAME;
                txtCount.Text = inventory.TOTAL.ToString();
                txtWare.Text = inventory.WareNAME;
                txtST.Text = string.IsNullOrEmpty(inventory.STID) ? "全部" : inventory.STNAME;
                txtSL.Text = string.IsNullOrEmpty(inventory.SLID) ? "全部" : inventory.SLNAME;
                txtType.Text = string.IsNullOrEmpty(inventory.TYPEID) ? "全部" : inventory.TYPENAME;
                Status = (InventoryStatus)inventory
                    .STATUS;
                WAREID = inventory.WAREID;
                STID = inventory.STID;
                SLID = inventory.SLID;
                if (Status == InventoryStatus.盘点结束 || Status == InventoryStatus.盘点未开始)
                {
                    plButton.Visible = false;
                }


                //获得需要盘点的资产列表
                assList = _autofacConfig.AssInventoryService.GetPendingInventoryList(IID);

                //得到盘点单当前的所有行项
                assDictionary = _autofacConfig.AssInventoryService.GetResultDictionary(IID);

                //得到待盘点的资产列表
                var waiTable1 = _autofacConfig.AssInventoryService.GetPendingInventoryTable(IID, WAREID,STID,SLID, typeId);
                foreach (DataRow row in waiTable1.Rows)
                {
                    DataRow Row = waiTable.NewRow();
                    Row["ASSID"] = row["ASSID"].ToString();
                    Row["RESULTNAME"] = row["RESULTNAME"].ToString();
                    Row["Image"] = row["Image"].ToString();
                    Row["SLName"] = row["SLName"].ToString();
                    Row["Name"] = row["Name"].ToString();
                    Row["Price"] = row["Price"].ToString();
                    Row["SN"] = row["SN"].ToString();
                    Row["TypeName"] = row["TypeName"].ToString();
                    Row["Specification"] = row["Specification"].ToString();


                    waiTable.Rows.Add(Row);
                }
                if (inventory.TOTAL == 0)
                {
                    txtCount.Text = waiTable1.Rows.Count.ToString();
                }


                //得到已盘点的资产列表
                var alreadyTable1 = _autofacConfig.AssInventoryService.GetAssInventoryResultsByIID(IID, ResultStatus.存在);
                foreach (DataRow row in alreadyTable1.Rows)
                {
                    DataRow Row = alreadyTable.NewRow();
                    Row["ASSID"] = row["ASSID"].ToString();
                    Row["RESULTNAME"] = row["RESULTNAME"].ToString();
                    Row["Image"] = row["Image"].ToString();
                    Row["SLName"] = row["SLName"].ToString();
                    Row["Name"] = row["Name"].ToString();
                    Row["Price"] = row["Price"].ToString();
                    Row["SN"] = row["SN"].ToString();
                    Row["TypeName"] = row["TypeName"].ToString();
                    Row["Specification"] = row["Specification"].ToString();

                    alreadyTable.Rows.Add(Row);
                }

                if (Status == InventoryStatus.盘点结束 || Status == InventoryStatus.盘点未开始)
                {
                    Form.ActionButton.Enabled = false;
                }

                //绑定数据
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 按回退键,就关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssInventoryResult_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();

            }

        }

        /// <summary>
        /// 手机扫描到二维码时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barcodeScanner1_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                string barCode = e.Value;
                string assId = "";
                //根据sn得到Assid
                var asset = _autofacConfig.SettingService.GetAssetsBySN(barCode);
                if (asset != null && asset.Rows.Count == 1)
                {
                    assId = asset.Rows[0]["ASSID"].ToString();
                    AddAssToDictionary(assId, barCode);

                }
                else
                {
                    Toast("未找到该SN对应的资产编号.");
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 手持设备扫描到二维码时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000Scanner1_BarcodeDataCaptured(object sender, Smobiler.Device.R2000BarcodeScanEventArgs e)
        {
            try
            {
                string barCode = e.Data;
                string assId = "";
                //根据sn得到Assid
                var asset = _autofacConfig.SettingService.GetAssetsBySN(barCode);
                if (asset != null && asset.Rows.Count == 1)
                {
                    assId = asset.Rows[0]["ASSID"].ToString();
                    AddAssToDictionary(assId, barCode);

                }
                else
                {
                    Toast("未找到该SN对应的资产编号.");
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 把扫描到的资产添加到对应的Dictionary
        /// </summary>
        /// <param name="assid">资产编号</param>
        private void AddAssToDictionary(string assid, string SN)
        {
            lock (lockobj)
            {
                if (assList.Contains(assid))
                {
                    //如果状态是待盘点，则变成已盘点
                    DataRow row = waiTable.Rows.Find(assid);
                    if (row != null)
                    {
                        DataRow newRow = getNewRow(row, ResultStatus.存在);
                        assDictionary[assid] = (int)ResultStatus.存在;
                        alreadyTable.Rows.Add(newRow);

                        var newdt = alreadyTable.Clone();
                        newdt.ImportRow(newRow);

                        alreadyListView.NewRow(newdt, "");
                        waitListView.Rows.RemoveAt(waiTable.Rows.IndexOf(row));
                        waiTable.Rows.Remove(row);
                    }
                }
                else
                {
                    //如果本来是不需要盘点的，状态改为盘盈
                    if (!assDictionary.ContainsKey(assid))
                    {
                        assDictionary.Add(assid, (int)ResultStatus.盘盈);
                    }
                    DataRow row = alreadyTable.Rows.Find(assid);
                    if (row == null)
                    {
                        DataRow asset = allAssTable.Rows.Find(SN);
                        if (asset != null)
                        {
                            DataRow newRow = getNewRow(asset,ResultStatus.盘盈);
                            alreadyTable.Rows.Add(newRow);

                            var newdt = alreadyTable.Clone();
                            newdt.ImportRow(newRow);
                            ((frmAIResultLayout)alreadyListView.NewRow(newdt, "")[0].Control).label2.ForeColor = Color.FromArgb(43, 140, 255);
                        }
                    }
                }
                string[] titleStrings = new string[2];
                titleStrings[0] = "待盘点(" + waiTable.Rows.Count.ToString() + ")";
                titleStrings[1] = "已盘点(" + alreadyTable.Rows.Count.ToString() + ")";
                tabPageView1.Titles = titleStrings;
            }
        }
        private DataRow getNewRow(DataRow datarow, ResultStatus status)
        {
            DataRow newRow = alreadyTable.NewRow();
            newRow["ASSID"] = datarow["ASSID"].ToString();
            newRow["Image"] = datarow["Image"].ToString();
            newRow["SLName"] = datarow["SLName"].ToString();
            newRow["Name"] = datarow["Name"].ToString();
            newRow["Price"] = datarow["Price"].ToString();
            newRow["SN"] = datarow["SN"].ToString();
            newRow["TypeName"] = datarow["TypeName"].ToString();
            newRow["Specification"] = datarow["Specification"].ToString();
            if (status == ResultStatus.盘盈)
                newRow["RESULTNAME"] = "盘盈";
            else
                newRow["RESULTNAME"] = "";
            return newRow;
        }
        /// <summary>
        /// 点击ActionButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssInventoryResult_ActionButtonPress(object sender, ActionButtonPressEventArgs e)
        {
            try
            {
                ReturnInfo rInfo = new ReturnInfo();
                switch (e.Index)
                {
                    case 0:
                        //上传结果
                        AssInventoryInputDto inputDto = new AssInventoryInputDto
                        {
                            IID = IID,
                            IsEnd = false,
                            AssDictionary = assDictionary
                        };
                        inputDto.IsEnd = false;
                        rInfo = _autofacConfig.AssInventoryService.UpdateInventory(inputDto);
                        Toast(rInfo.IsSuccess ? "上传结果成功." : rInfo.ErrorInfo);
                        break;
                    case 1:
                        //盘点结束
                        Dictionary<string, int> assDictionary2 = new Dictionary<string, int>();
                        foreach (var key in assDictionary.Keys)
                        {

                            if (assDictionary[key] == (int)ResultStatus.待盘点)
                            {
                                assDictionary2.Add(key, (int)ResultStatus.盘亏);
                            }
                            else
                            {
                                assDictionary2.Add(key, assDictionary[key]);
                            }
                        }


                        AssInventoryInputDto inputDto2 = new AssInventoryInputDto
                        {
                            IID = IID,
                            IsEnd = false,
                            AssDictionary = assDictionary2
                        };
                        inputDto2.IsEnd = true;
                        rInfo = _autofacConfig.AssInventoryService.UpdateInventory(inputDto2);
                        if (rInfo.IsSuccess)
                        {
                            ShowResult = ShowResult.Yes;
                            Close();
                            Toast("盘点结束成功.");
                        }
                        else
                        {
                            Toast(rInfo.ErrorInfo);
                        }
                        break;
                    default:
                        break;

                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }


        }
        private static object lockobj = new object();
        /// <summary>
        /// 绑定数据
        /// </summary>
        private void Bind()
        {
            lock (lockobj)
            {
                try
                {
                    waitListView.Rows.Clear();
                    waitListView.DataSource = waiTable;
                    waitListView.DataBind();

                    alreadyListView.Rows.Clear();
                    alreadyListView.DataSource = alreadyTable;
                    alreadyListView.DataBind();
                    string[] titleStrings = new string[2];
                    titleStrings[0] = "待盘点(" + waiTable.Rows.Count.ToString() + ")";
                    titleStrings[1] = "已盘点(" + alreadyTable.Rows.Count.ToString() + ")";
                    tabPageView1.Titles = titleStrings;

                    foreach (var row in alreadyListView.Rows)
                    {
                        frmAIResultLayout layout = (frmAIResultLayout)row.Control;
                        if (layout.label2.Text == "盘亏")
                            layout.label2.ForeColor = Color.Red;
                        if (layout.label2.Text == "盘盈")
                            layout.label2.ForeColor = Color.FromArgb(43, 140, 255);
                    }
                }
                catch (Exception ex)
                {
                    Toast(ex.Message);
                }
            }

        }

        /// <summary>
        /// 点击"扫描添加"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelScan_Press(object sender, EventArgs e)
        {
            if (Status == InventoryStatus.盘点结束 || Status == InventoryStatus.盘点未开始)
            {
                Toast("盘点未开始或已经结束.");
            }
            else
            {
                barcodeScanner1.GetBarcode();
            }
        }
        /// <summary>
        /// 扫描到RFID时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000Scanner1_RFIDDataCaptured(object sender, Smobiler.Device.R2000RFIDScanEventArgs e)
        {
            string RFID = e.Epc;
            string assId = "";

            DataRow row = allAssTable.Rows.Find(RFID);
            if (row != null)
            {
                assId = row["ASSID"].ToString();
                if ((assList.Contains(assId) && waiTable.Rows.Find(assId) != null) ||
                    (!assDictionary.ContainsKey(assId) && alreadyTable.Rows.Find(assId) == null))
                {
                    AddAssToDictionary(assId, RFID);
                }
            }
        }
    }
}