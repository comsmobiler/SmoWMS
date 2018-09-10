using System;
using Smobiler.Core.Controls;
using SMOWMS.DTOs.InputDTO;

namespace SMOWMS.UI.Analyze.Assets
{
    partial class frmImminentExpiryAss : Smobiler.Core.Controls.MobileForm
    {
        #region
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private DateTime startTime;
        private DateTime endTime;
        #endregion
        public frmImminentExpiryAss() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void btnTime_Press(object sender, EventArgs e)
        {
            try
            {
                popTime.Groups.Clear();
                PopListGroup timeGroup = new PopListGroup { Title = "几天内过期" };
                timeGroup.AddListItem("一个月", "OM");
                timeGroup.AddListItem("半个月", "15");
                timeGroup.AddListItem("一周", "7");

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
                if (popTime.Selection != null)
                {
                    switch (popTime.Selection.Value)
                    {
                        case "OM":
                            endTime = DateTime.Now.Date.AddMonths(1);
                            break;
                        case "15":
                            endTime = DateTime.Now.Date.AddDays(15);
                            break;
                        case "7":
                            endTime = DateTime.Now.Date.AddDays(7);
                            break;
                    }
                    btnTime.Text = popTime.Selection.Text + "   > ";
                    Bind(); 
                }


            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void frmImminentExpiryAss_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
        }

        private void frmImminentExpiryAss_Load(object sender, EventArgs e)
        {
            try
            {
                startTime = DateTime.Now.Date;
                endTime = DateTime.Now.Date.AddMonths(1);
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        private void Bind()
        {
            try
            {
                QueryAssAnalysisInputDto inputDto = new QueryAssAnalysisInputDto
                {
                    StarTime = startTime,
                    EndTime = endTime
                };
                var rows = _autofacConfig.AssAnalysisService.GetImminentExpiryAss(inputDto);
                lvRow.DataSource = rows;
                lvRow.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}