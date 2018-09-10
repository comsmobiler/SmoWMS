using System;
using System.Collections.Generic;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.UI.Layout;

namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssSalesOrderResult : Smobiler.Core.Controls.MobileForm
    {
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
//        private string UserId;  //用户编号
        public List<string> PORowIds = new List<string>();
        public string SOID;
        public List<int> selectRowList = new List<int>();
        public int Status;
        #endregion

        /// <summary>
        /// 界面初始化时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssSalesOrderResult_Load(object sender, EventArgs e)
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
        /// 按回退，则关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssSalesOrderResult_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
        }

        /// <summary>
        /// 按ActionButton时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssSalesOrderResult_ActionButtonPress(object sender, ActionButtonPressEventArgs e)
        {
            try
            {
                switch (e.Index)
                {
                    case 0:
                        //出库
                        switch (Status)
                        {
                            case 2:
                                throw new Exception("出库已完成！");
                            case 0:
                            case 1:
                                frmAssOut frmAssOut = new frmAssOut
                                {
                                    SOID = SOID,
                                    IsFromSO = true
                                };
                                Show(frmAssOut, (MobileForm sender1, object args) =>
                                {
                                    if (frmAssOut.ShowResult == ShowResult.Yes)
                                    {
                                        Bind();
                                    }
                                });
                                break;
                        }
                        break;
                    case 1:
                        //退库
                        switch (Status)
                        {
                            case 0:
                                throw new Exception("未开始出库，无法退库！");
                            case 2:
                            case 1:
                                frmAssRetiring frmAssRetiring = new frmAssRetiring
                                {
                                    SOID = SOID,
                                    IsFromSO = true
                                };
                                Show(frmAssRetiring, (MobileForm sender1, object args) =>
                                {
                                    if (frmAssRetiring.ShowResult == ShowResult.Yes)
                                    {
                                        Bind();
                                    }
                                });
                                break;
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
        /// 绑定数据
        /// </summary>
        public void Bind()
        {
            try
            {
                var po = _autofacConfig.AssSalesOrderService.GetById(SOID);
                lblName.Text = po.NAME;
                lblPMan.Text = po.SALESPERSONNAME;
                lblRealId.Text = po.REALID;
                lblStatus.Tag = po.STATUS;
                lblCustomer.Text = po.CUSNAME;
                lblTID.Text = SOID;
                Status = po.STATUS;
                switch (po.STATUS)
                {
                    case 1:
                        lblStatus.Text = "出库中";
                        break;
                    case 2:
                        lblStatus.Text = "已完成";
                        break;
                    case 0:
                        lblStatus.Text = "销售中";
                        break;
                }
                var row = _autofacConfig.AssSalesOrderService.GetRows(SOID);
                if (row.Rows.Count > 0)
                {
                    lvSORow.DataSource = row;
                    lvSORow.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}