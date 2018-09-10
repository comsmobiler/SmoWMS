using System;
using System.Collections.Generic;
using Smobiler.Core.Controls;
using System.Data;
using SMOWMS.DTOs.Enum;
using System.Drawing;
using System.Windows.Forms;
using ListView = Smobiler.Core.Controls.ListView;
using SMOWMS.UI.Layout;
using SMOWMS.CommLib;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmConInventoryResult : Smobiler.Core.Controls.MobileForm
    {
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public string IID; //盘点单编号
        private string UserId;  //用户编号
        private DataTable waiTable = new DataTable(); //待盘点的耗材
        private DataTable alreadyTable = new DataTable(); //已盘点的耗材
        private Dictionary<string, List<decimal>> conDictionary = new Dictionary<string, List<decimal>>();  //耗材
        private List<string> conList;  //耗材的初始列表

        internal String[] locData;          //库位信息:仓库编号,存储类型编号，库位编号
        private ListView waitListView = new ListView();
        private ListView alreadyListView = new ListView();
        public InventoryStatus Status;
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConInventoryResult_Load(object sender, EventArgs e)
        {
            try
            {
                UserId = Client.Session["UserID"].ToString();
                //添加各表格的列
                if (waiTable.Columns.Count == 0)
                {
                    waiTable.Columns.Add("RESULTNAME");
                    waiTable.Columns.Add("CID");
                    waiTable.Columns.Add("LOCID");      //   仓库编号/存储类型编号/库位编号
                    waiTable.Columns.Add("LOCNAME");    //   仓库名称/存储类型名称/库位名称
                    waiTable.Columns.Add("Image");
                    waiTable.Columns.Add("Name");
                    waiTable.Columns.Add("Total");
                    waiTable.Columns.Add("RealAmount");
                }
                DataColumn[] waitKey = new DataColumn[2];
                waitKey[0] = waiTable.Columns["CID"];
                waitKey[1] = waiTable.Columns["LOCID"];
                waiTable.PrimaryKey = waitKey;

                //添加各表格的列
                if (alreadyTable.Columns.Count == 0)
                {
                    alreadyTable.Columns.Add("RESULTNAME");
                    alreadyTable.Columns.Add("CID");
                    alreadyTable.Columns.Add("LOCID");      //   仓库编号/存储类型编号/库位编号
                    alreadyTable.Columns.Add("LOCNAME");    //   仓库名称/存储类型名称/库位名称
                    alreadyTable.Columns.Add("Image");
                    alreadyTable.Columns.Add("Name");
                    alreadyTable.Columns.Add("Total");
                    alreadyTable.Columns.Add("RealAmount");
                }
                DataColumn[] hasKey = new DataColumn[2];
                hasKey[0] = alreadyTable.Columns["CID"];
                hasKey[1] = alreadyTable.Columns["LOCID"];
                alreadyTable.PrimaryKey = hasKey;

                //添加ListView到tabpageview
                waitListView.TemplateControlName = "frmCIResultLayout";
                waitListView.ShowSplitLine = true;
                waitListView.SplitLineColor = Color.FromArgb(230, 230, 230);
                waitListView.Dock = DockStyle.Fill;
                tabPageView1.Controls.Add(waitListView);

                alreadyListView.TemplateControlName = "frmCIResultLayout";
                alreadyListView.ShowSplitLine = true;
                alreadyListView.SplitLineColor = Color.FromArgb(230, 230, 230);
                alreadyListView.Dock = DockStyle.Fill;
                tabPageView1.Controls.Add(alreadyListView);

                var inventory = _autofacConfig.ConInventoryService.GetConInventoryById(IID);
                lblName.Text = inventory.NAME;
                lblHandleMan.Text = inventory.HANDLEMANNAME;
                lblCount.Text = inventory.TOTAL.ToString();
                lblWareHouse.Text = inventory.WARENAME;
                lblWareHouse.Tag = inventory.WAREID;
                lblST.Text = inventory.STNAME;
                lblST.Tag = inventory.STID;
                lblSL.Text = inventory.SLNAME;
                lblSL.Tag = inventory.SLID;
                Status = (InventoryStatus)inventory
                    .STATUS;

                if (Status == InventoryStatus.盘点结束 || Status == InventoryStatus.盘点未开始)
                {
                    panelScan.Visible = false;
                }
                //获得需要盘点的资产列表
                conList = _autofacConfig.ConInventoryService.GetPendingInventoryList(IID);

                //得到盘点单当前的所有行项
                conDictionary = _autofacConfig.ConInventoryService.GetResultDictionary(IID);

                String STID = (lblST.Tag == null) ? null : lblST.Tag.ToString();
                String SLID = (lblSL.Tag == null) ? null : lblSL.Tag.ToString();
                //得到待盘点的资产列表
                DataTable waiTable1 = _autofacConfig.ConInventoryService.GetPendingInventoryTable(IID, lblWareHouse.Tag.ToString(), STID, SLID);
                foreach (DataRow row in waiTable1.Rows)
                {
                    DataRow Row = waiTable.NewRow();
                    Row["CID"] = row["CID"].ToString();
                    Row["LOCID"] = row["WAREID"] + "/" + row["STID"] + "/" + row["SLID"];
                    Row["LOCNAME"] = row["WARENAME"] + "/" + row["STNAME"] + "/" + row["SLNAME"];
                    Row["RESULTNAME"] = row["RESULTNAME"].ToString();
                    Row["Image"] = row["Image"].ToString();
                    Row["Name"] = row["Name"].ToString();
                    Row["Total"] = row["Total"].ToString();
                    Row["RealAmount"] = row["RealAmount"].ToString();

                    waiTable.Rows.Add(Row);
                }
                if (inventory.TOTAL == 0)
                {
                    lblCount.Text = waiTable1.Rows.Count.ToString();
                }


                //得到已盘点的资产列表
                var alreadyTable1 = _autofacConfig.ConInventoryService.GetConInventoryResultsByIID(IID, ResultStatus.已盘点);
                foreach (DataRow row in alreadyTable1.Rows)
                {
                    DataRow Row = alreadyTable.NewRow();
                    Row["CID"] = row["CID"].ToString();
                    Row["LOCID"] = row["WAREID"] + "/" + row["STID"] + "/" + row["SLID"];
                    Row["LOCNAME"] = row["WARENAME"] + "/" + row["STNAME"] + "/" + row["SLNAME"];
                    Row["RESULTNAME"] = row["RESULTNAME"].ToString();
                    Row["Image"] = row["Image"].ToString();
                    Row["Name"] = row["Name"].ToString();
                    Row["Total"] = row["Total"].ToString();
                    Row["RealAmount"] = row["RealAmount"].ToString();

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
        /// 数据加载
        /// </summary>
        private void Bind()
        {
            try
            {
                waitListView.Rows.Clear();
                waitListView.DataSource = waiTable;
                waitListView.DataBind();

                alreadyListView.Rows.Clear();
                alreadyListView.DataSource = alreadyTable;
                alreadyListView.DataBind();

                tabPageView1.Titles = new string[] {
                    "待盘点(" + waiTable.Rows.Count.ToString() + ")",
                    "已盘点(" + alreadyTable.Rows.Count.ToString() + ")" };

                foreach (var row in alreadyListView.Rows)
                {
                    frmCIResultLayout layout = (frmCIResultLayout)row.Control;
                    if (layout.label2.Text == "盘亏")
                        layout.label2.ForeColor = Color.Red;
                    else if (layout.label2.Text == "盘盈")
                        layout.label2.ForeColor = Color.FromArgb(43, 140, 255);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 盘点上传或盘点结束
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConInventoryResult_ActionButtonPress(object sender, ActionButtonPressEventArgs e)
        {
            try
            {
                ReturnInfo rInfo = new ReturnInfo();
                switch (e.Index)
                {
                    case 0:
                        //上传结果
                        ConInventoryInputDto inputDto = new ConInventoryInputDto
                        {
                            IID = IID,
                            IsEnd = false,
                            ConDictionary = conDictionary,
                            WAREID = lblWareHouse.Tag.ToString(),
                            MODIFYUSER = UserId
                        };
                        if (lblST.Tag != null) inputDto.STID = lblST.Tag.ToString();
                        if (lblSL.Tag != null) inputDto.SLID = lblSL.Tag.ToString();
                        rInfo = _autofacConfig.ConInventoryService.UpdateInventory(inputDto);
                        Toast(rInfo.IsSuccess ? "上传结果成功!" : rInfo.ErrorInfo);
                        break;
                    case 1:
                        //盘点结束
                        Dictionary<string, List<decimal>> conDictionary2 = new Dictionary<string, List<decimal>>();
                        foreach (var key in conDictionary.Keys)
                        {
                            if (conDictionary[key][1] == (int)ResultStatus.待盘点)
                            {
                                List<decimal> list = new List<decimal>();
                                list.Add(0);
                                list.Add(Convert.ToDecimal((int)ResultStatus.盘亏));
                                conDictionary2.Add(key, list);
                            }
                            else
                            {
                                conDictionary2.Add(key, conDictionary[key]);
                            }
                        }

                        ConInventoryInputDto inputDto2 = new ConInventoryInputDto
                        {
                            IID = IID,
                            WAREID = lblWareHouse.Tag.ToString(),
                            IsEnd = true,
                            ConDictionary = conDictionary2
                        };
                        inputDto2.IsEnd = true;
                        rInfo = _autofacConfig.ConInventoryService.UpdateInventory(inputDto2);
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
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 耗材扫描
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barcodeScanner1_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                string locId = e.Value;
                locData = locId.Split('/');
                if (locData.Length != 3) throw new Exception("库位条码错误");
                WHStorageLocationOutputDto sloc = _autofacConfig.wareHouseService.GetSLByID(locData[0], locData[1], locData[2]);
                if (sloc == null) throw new Exception("该库位不存在");
                List<ConInventoryResult> resultList = _autofacConfig.ConInventoryService.GetResultListBySL(IID, locData[0], locData[1], locData[2]);
                if (resultList.Count == 0) throw new Exception("该库位下无可盘点耗材");

                frmCIResultTotalLayout frm = new frmCIResultTotalLayout();
                frm.lblSL.Text =sloc.WARENAME+"/"+sloc.STNAME+"/"+sloc.SLNAME;
                Form.ShowDialog(frm);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 盘点耗材，刷新界面
        /// </summary>
        /// <param name="CID"></param>
        /// <param name="RealNumber"></param>
        public void AddConToDictionary(string CID, Decimal RealAmount)
        {
            WHStorageLocationOutputDto locOutputData = _autofacConfig.wareHouseService.GetSLByID(locData[0], locData[1], locData[2]);
            String locId = locData[0] + "/" + locData[1] + "/" + locData[2];
            String locName = locOutputData.WARENAME + "/" + locOutputData.STNAME + "/" + locOutputData.SLNAME;
            String dictionaryKey = CID + "/" + locData[0] + "/" + locData[1] + "/" + locData[2];
            if (conList.Contains(dictionaryKey))
            {
                //如果本来是需要盘点的，状态改为已盘点
                conDictionary[dictionaryKey][0] = RealAmount;
                object[] keys = new object[2];
                keys[0] = CID;
                keys[1] = locData[0] + "/" + locData[1] + "/" + locData[2];
                //如果待盘点的datatable存在该资产，从待盘点中删除，并加入到已盘点datatable
                DataRow row = waiTable.Rows.Find(keys);
                if (row != null)
                {
                   
                    DataRow alreadyRow = alreadyTable.NewRow();
                    alreadyRow["CID"] = row["CID"].ToString();
                    alreadyRow["LOCID"] = locId;
                    alreadyRow["LOCNAME"] = locName;
                    alreadyRow["Image"] = row["Image"].ToString();
                    alreadyRow["Name"] = row["Name"].ToString();
                    alreadyRow["Total"] = row["Total"].ToString();
                    alreadyRow["RealAmount"] = RealAmount;
                    if (Convert.ToDecimal(row["Total"]) < RealAmount)
                    {
                        alreadyRow["RESULTNAME"] = "盘盈";
                        conDictionary[dictionaryKey][1] = (int)ResultStatus.盘盈;
                    }
                    else if (Convert.ToDecimal(alreadyRow["Total"]) > RealAmount)
                    {
                        alreadyRow["RESULTNAME"] = "盘亏";
                        conDictionary[dictionaryKey][1] = (int)ResultStatus.盘亏;
                    }
                    else
                    {
                        alreadyRow["RESULTNAME"] = "存在";
                        conDictionary[dictionaryKey][1] = (int)ResultStatus.存在;
                    }
                    alreadyTable.Rows.Add(alreadyRow);
                    waiTable.Rows.Remove(row);
                }
                else
                {
                    if (conDictionary[dictionaryKey][1] != (int)ResultStatus.盘盈)
                    {
                        DataRow Arow = alreadyTable.Rows.Find(keys);
                        if (Convert.ToDecimal(Arow["Total"]) < RealAmount)
                        {
                            conDictionary[dictionaryKey][1] = (int)ResultStatus.盘盈;
                            Arow["RealAmount"] = RealAmount;
                            Arow["RESULTNAME"] = "盘盈";
                        }
                        else if (Convert.ToDecimal(Arow["Total"]) > RealAmount)
                        {
                            conDictionary[dictionaryKey][1] = (int)ResultStatus.盘亏;
                            Arow["RealAmount"] = RealAmount;
                            Arow["RESULTNAME"] = "盘亏";
                        }
                        else
                        {
                            conDictionary[dictionaryKey][1] = (int)ResultStatus.存在;
                            Arow["RealAmount"] = RealAmount;
                            Arow["RESULTNAME"] = "";
                        }
                    }
                    else
                    {
                        DataRow Arow = alreadyTable.Rows.Find(keys);
                        if (Convert.ToDecimal(Arow["Total"]) < RealAmount)
                        {
                            Arow["RealAmount"] = RealAmount;
                        }
                        else if (Convert.ToDecimal(Arow["Total"]) >= RealAmount)
                        {
                            if (Convert.ToDecimal(Arow["Total"]) > RealAmount)
                            {
                                conDictionary[dictionaryKey][1] = (int)ResultStatus.盘亏;
                                Arow["RESULTNAME"] = "盘亏";
                            }
                            else
                            {
                                conDictionary[dictionaryKey][1] = (int)ResultStatus.存在;
                                Arow["RESULTNAME"] = "";
                            }
                        }
                    }
                }
            }
            else
            {
                //如果本来是不需要盘点的，状态改为盘盈
                if (!conDictionary.ContainsKey(dictionaryKey))
                {
                    List<decimal> list = new List<decimal>();
                    list.Add(RealAmount);
                    list.Add(Convert.ToDecimal((int)ResultStatus.盘盈));
                    conDictionary.Add(dictionaryKey, list);
                }
                DataRow row = alreadyTable.Rows.Find(CID);
                if (row == null)
                {
                    var con = _autofacConfig.consumablesService.GetConsById(CID);

                    DataRow moreRow = alreadyTable.NewRow();
                    moreRow["CID"] = con.CID;
                    moreRow["LOCID"] = locId;
                    moreRow["LOCNAME"] = locName;
                    moreRow["RESULTNAME"] = "盘盈";
                    moreRow["Image"] = con.IMAGE;
                    moreRow["Name"] = con.NAME;
                    moreRow["Total"] = 0;
                    moreRow["RealAmount"] = RealAmount;
                    alreadyTable.Rows.Add(moreRow);
                }
                else
                {
                    row["RealAmount"] = RealAmount;
                }
            }
            Bind();
        }
        /// <summary>
        /// 二维码扫描
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
                bsSL.GetBarcode();
            }
        }
    }
}