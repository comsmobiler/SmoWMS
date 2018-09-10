using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Smobiler.Core.Controls;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using ListView = Smobiler.Core.Controls.ListView;

namespace SMOWMS.UI.Analyze.Assets
{
    partial class frmAssCusAnalysis : Smobiler.Core.Controls.MobileForm
    {
        #region
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private DateTime startTime;
        private DateTime endTime;
        private BarChart bc = new BarChart();
        private ListView lv = new ListView();
        #endregion
        public frmAssCusAnalysis() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void dpStart_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dpStart.Value > endTime)
                {
                    dpStart.Value = startTime;
                    throw new Exception("起始时间必须小于等于结束时间！");
                }
                startTime = dpStart.Value;
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void dpEnd_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dpEnd.Value < startTime)
                {
                    dpEnd.Value = endTime;
                    throw new Exception("结束时间必须大于等于起始时间！");
                }
                endTime = dpEnd.Value.Date.AddDays(1);
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void btnTime_Press(object sender, EventArgs e)
        {
            try
            {
                popTime.Groups.Clear();
                PopListGroup timeGroup = new PopListGroup { Title = "时间" };
                timeGroup.AddListItem("本年", "Year");
                timeGroup.AddListItem("本月", "Month");
                timeGroup.AddListItem("本周", "Week");
                timeGroup.AddListItem("本日", "Day");

                popTime.Groups.Add(timeGroup);
                if (btnTime.Tag != null)
                {
                    foreach (PopListItem row in popTime.Groups[0].Items)
                    {
                        if (row.Value == btnTime.Tag.ToString())
                        {
                            popTime.SetSelections(row);
                        }
                    }
                }
                popTime.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


        private void popTime_Selected(object sender, EventArgs e)
        {
            try
            {
                switch (popTime.Selection.Value)
                {
                    case "Year":
                        startTime = new DateTime(DateTime.Now.Year, 1, 1);

                        break;
                    case "Month":
                        startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                        break;
                    case "Week":
                        startTime = GetWeekFirstDayMon(DateTime.Now);
                        break;
                    case "Day":
                        startTime = DateTime.Now.Date;
                        break;
                }
                btnTime.Text = popTime.Selection.Text + "   > ";
                dpStart.Value = startTime;
                dpEnd.Value = DateTime.Now.Date;
                endTime = DateTime.Now.Date.AddDays(1);
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void btnCus_Press(object sender, EventArgs e)
        {
            try
            {
                popCus.Groups.Clear();
                PopListGroup cusGroup = new PopListGroup { Title = "客户选择" };
                cusGroup.AddListItem("全部", "");
                List<Customer> customers = _autofacConfig.customerService.GetAll();
                foreach (Customer Row in customers)
                {
                    cusGroup.AddListItem(Row.NAME, Row.CUSID.ToString());
                }
                popCus.Groups.Add(cusGroup);
                if (btnCus.Tag != null)   //如果已有选中项，则显示选中效果
                {
                    foreach (PopListItem Item in cusGroup.Items)
                    {
                        if (Item.Value == btnCus.Tag.ToString())
                            popCus.SetSelections(Item);
                    }
                }
                popCus.ShowDialog();

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void popCus_Selected(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(popCus.Selection.Text) == false)
            {
                btnCus.Text = popCus.Selection.Text + "   > ";
                btnCus.Tag = popCus.Selection.Value;         //采购人编号
                Bind();
            }
        }

        private void Bind()
        {
            try
            {
                int? Id = null;;
                if (!string.IsNullOrEmpty(btnCus.Tag?.ToString()))
                {
                    Id = int.Parse(btnCus.Tag.ToString());
                }
                QueryAssCusandVenAnalysisInputDto inputDto = new QueryAssCusandVenAnalysisInputDto
                {
                    StarTime = startTime,
                    EndTime = endTime,
                    ID = Id
                };
                var chartInfo = _autofacConfig.AssAnalysisService.GetAssCustomerAnalysisChart(inputDto);
                bc.DataSource = chartInfo;
                bc.DataBind();

                var rows = _autofacConfig.AssAnalysisService.GetAssCustomerAnalysis(inputDto);
                lv.DataSource = rows;
                lv.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void frmAssCusAnalysis_Load(object sender, EventArgs e)
        {
            try
            {
                startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                endTime = DateTime.Now.Date.AddDays(1);
                dpStart.Value = startTime;
                dpEnd.Value = endTime;

                bc.Name = "barChart1";
                bc.SeriesMember = "Series";
                bc.Dock = System.Windows.Forms.DockStyle.Fill;
                bc.XAxisValues = new string[0];
                bc.XValueMember = "XValue";
                bc.YValueMember = "YValue";
                bc.Margin = new Margin(0, 20, 0, 0);
                tpvData.Controls.Add(bc);


                lv.TemplateControlName = "frmAssCusAnalysisLayout";
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

        private void frmAssCusAnalysis_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
        }

        /// <summary>  
        /// 得到本周第一天(以星期一为第一天)  
        /// </summary>  
        /// <param name="datetime"></param>  
        /// <returns></returns>  
        public DateTime GetWeekFirstDayMon(DateTime datetime)
        {
            //星期一为第一天  
            int weeknow = Convert.ToInt32(datetime.DayOfWeek);

            //因为是以星期一为第一天，所以要判断weeknow等于0时，要向前推6天。  
            weeknow = (weeknow == 0 ? (7 - 1) : (weeknow - 1));
            int daydiff = (-1) * weeknow;

            //本周第一天  
            string FirstDay = datetime.AddDays(daydiff).ToString("yyyy-MM-dd");
            return Convert.ToDateTime(FirstDay);
        }
    }
}