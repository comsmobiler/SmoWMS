using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Smobiler.Core.Controls;
using SMOWMS.UI.Layout;
using ListView = Smobiler.Core.Controls.ListView;

namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssSourceChoose : Smobiler.Core.Controls.MobileForm
    {
        public DataTable AssTable=new DataTable();

        public string LocationId;

        public OperationType OperationType;

        public string UserId;

        public List<string> AssIdList=new List<string>();

        private ListView _assListView=new ListView();

        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        
        private void Checkall_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Checkall.Checked)
                {
                    foreach (var row in _assListView.Rows)
                    {
                        AssSelectLayout layout = (AssSelectLayout) row.Control;
                        layout.CheckBox1.Checked = true;

                    }

                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                ShowResult = ShowResult.Yes;
                Close();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void tpvAssets_PageIndexChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void plSearch_Press(object sender, EventArgs e)
        {
            try
            {
                Bind(txtFactor.Text);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void FrmSourceChoose_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Close();
        }

        private void FrmSourceChoose_Load(object sender, EventArgs e)
        {
            try
            {
                _assListView.TemplateControlName = "AssSelectLayout";
                _assListView.ShowSplitLine = true;
                _assListView.SplitLineColor = Color.FromArgb(230, 230, 230);
                _assListView.Dock = DockStyle.Fill;
                tpvAssets.Controls.Add(_assListView);

                UserId = "";
                Bind(null);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void Bind(string name)
        {
            try
            {
                if (AssTable.Columns.Count == 0)
                {
                    AssTable.Columns.Add("IMAGE");
                    AssTable.Columns.Add("ASSID");
                    AssTable.Columns.Add("NAME");
                    AssTable.Columns.Add("TYPE");
                    AssTable.Columns.Add("SN");
//                    AssTable.Columns.Add("IsChecked", Type.GetType("System.Boolean"));
//                    AssTable.Columns.Add("IsChecked");
                }
                DataColumn[] keys = new DataColumn[1];
                keys[0] = AssTable.Columns["ASSID"];
                AssTable.PrimaryKey = keys;

                DataTable assTable=new DataTable();
//                switch (OperationType)
//                {
//                    case OperationType.借用:
//                    case OperationType.领用:
//                        assTable = _autofacConfig.SettingService.GetUnUsedAss(LocationId, name);
//                        break;
//                    case OperationType.归还:
//                        assTable = _autofacConfig.SettingService.GetBorrowedAss(LocationId, name,UserId);
//                        break;
//                    case OperationType.退库:
//                        assTable = _autofacConfig.SettingService.GetInUseAss(LocationId, name,UserId);
//                        break;
//                }
                foreach (DataRow row in assTable.Rows)
                {
                    if (AssIdList.Contains(row["AssId"].ToString()))
                    {
                        row["IsChecked"] = true;
                    }
                }

                if (assTable.Rows.Count > 0)
                {
                    _assListView.DataSource = assTable;
                    _assListView.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        public void AddAss(string assId, string sn, string image, string name)
        {
            try
            {
                if (AssIdList.Contains(assId))
                {
                    throw new Exception("已添加过该资产。");
                }
                else
                {
                    DataRow row = AssTable.NewRow();
                    row["ASSID"] = assId;
                    row["SN"] = sn;
                    row["IMAGE"] = image;
                    row["NAME"] = name;
//                    row["IsChecked"] = true;
                    switch (OperationType)
                    {
                        case OperationType.借用:
                            row["TYPE"] = "BO";
                            break;
                        case OperationType.领用:
                            row["TYPE"] = "CO";
                            break;
                        case OperationType.归还:
                            row["TYPE"] = "RTO";
                            break;
                        case OperationType.退库:
                            row["TYPE"] = "RSO";
                            break;
                    }
                    AssTable.Rows.Add(row);
                    AssIdList.Add(assId);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        public void RemoveAss(string assId)
        {
            try
            {
                DataRow row = AssTable.Rows.Find(assId);
                AssTable.Rows.Remove(row);
                AssIdList.Remove(assId);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        public void UpdateCheckState()
        {
            try
            {
//                int selectcount = 0;
                if (AssTable.Rows.Count == AssIdList.Count)
                {
                    Checkall.Checked = true;
                }
                else
                {
                    Checkall.Checked = false;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}