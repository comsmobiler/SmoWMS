using System;
using System.Drawing;
using System.Windows.Forms;
using Smobiler.Core.Controls;
using SMOWMS.DTOs.InputDTO;
using ListView = Smobiler.Core.Controls.ListView;

namespace SMOWMS.UI.Analyze.Assets
{
    partial class frmAssQuantAnalysis : Smobiler.Core.Controls.MobileForm
    {
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private BarChart bc = new BarChart();
        private ListView lv = new ListView();
        public frmAssQuantAnalysis() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void btnWare_Press(object sender, EventArgs e)
        {
            try
            {
                popWare.Groups.Clear();
                PopListGroup whGroup = new PopListGroup { Title = "仓库" };
                var whlist = _autofacConfig.wareHouseService.GetAllWareHouse();
                PopListItem first = new PopListItem
                {
                    Text = "全部仓库",
                    Value = ""
                };
                whGroup.Items.Add(first);
                foreach (var wh in whlist)
                {
                    PopListItem item = new PopListItem
                    {
                        Value = wh.WAREID,
                        Text = wh.NAME
                    };
                    whGroup.Items.Add(item);
                }
                popWare.Groups.Add(whGroup);
                if (btnWare.Tag != null)
                {
                    foreach (PopListItem row in popWare.Groups[0].Items)
                    {
                        if (row.Value == btnWare.Tag.ToString())
                        {
                            popWare.SetSelections(row);
                        }
                    }
                }
                popWare.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void btnType_Press(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    popType.Groups.Clear();
                    PopListGroup typeGroup = new PopListGroup { Title = "资产类型" };
                    var typelist = _autofacConfig.assTypeService.GetAll();
                    PopListItem first = new PopListItem
                    {
                        Text = "全部类型",
                        Value = ""
                    };
                    typeGroup.Items.Add(first);
                    foreach (var type in typelist)
                    {
                        PopListItem item = new PopListItem
                        {
                            Value = type.TYPEID,
                            Text = type.NAME
                        };
                        typeGroup.Items.Add(item);
                    }
                    popType.Groups.Add(typeGroup);
                    if (btnType.Tag != null)
                    {
                        foreach (PopListItem row in popType.Groups[0].Items)
                        {
                            if (row.Value == btnType.Tag.ToString())
                            {
                                popType.SetSelections(row);
                            }
                        }
                    }
                    popType.ShowDialog();
                }
                catch (Exception ex)
                {
                    Toast(ex.Message);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void popWare_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popWare.Selection != null)
                {
                    btnWare.Text = popWare.Selection.Text + "   > ";
                    //给btnWareHouse.Tag赋值最新的值
                    btnWare.Tag = popWare.Selection.Value;
                    Bind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void popType_Selected(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (popType.Selection != null)
                    {
                        btnType.Text = popType.Selection.Text + "   > ";
                        btnType.Tag = popType.Selection.Value;
                        Bind();
                    }
                }
                catch (Exception ex)
                {
                    Toast(ex.Message);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void frmAssQuantAnalysis_Load(object sender, EventArgs e)
        {
            try
            {
                btnWare.Tag = "";
                btnType.Tag = "";
                bc.Name = "barChart1";
                bc.SeriesMember = "WARENAME";
                bc.Dock = System.Windows.Forms.DockStyle.Fill;
                bc.XAxisValues = new string[0];
                bc.XValueMember = "TYPENAME";
                bc.YValueMember = "QUANT";
                bc.Margin = new Margin(0, 20, 0, 0);
                tpvData.Controls.Add(bc);


                lv.TemplateControlName = "frmAssQuantLayout";
                lv.ShowSplitLine = true;
                lv.SplitLineColor = Color.FromArgb(230, 230, 230);
                lv.Dock = DockStyle.Fill;
                tpvData.Controls.Add(lv);


                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void frmAssQuantAnalysis_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
        }

        private void Bind()
        {
            try
            {
                string wareId = btnWare == null ? "" : btnWare.Tag.ToString();
                string typeId = btnType == null ? "" : btnType.Tag.ToString();
                QueryAssQuantInputDto inputDto = new QueryAssQuantInputDto
                {
                    WAREID = wareId,
                    TYPEID = typeId
                };
                var chartInfo = _autofacConfig.AssAnalysisService.GetAssQuantChart(inputDto);
                bc.DataSource = chartInfo;
                bc.DataBind();

                var rows = _autofacConfig.AssAnalysisService.GetAssQuant(inputDto);
                lv.DataSource = rows;
                lv.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

    }
}