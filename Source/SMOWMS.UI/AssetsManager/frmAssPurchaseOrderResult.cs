using System;
using System.Collections.Generic;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.UI.Layout;

namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssPurchaseOrderResult : Smobiler.Core.Controls.MobileForm
    {
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public List<string> PORowIds=new List<string>();
        public string POID;
        public List<int> selectRowList=new List<int>();
        public int Status;
        #endregion

        /// <summary>
        /// 界面初始化时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssPurchaseOrderResult_Load(object sender, EventArgs e)
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
        /// 按ActionButton时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssPurchaseOrderResult_ActionButtonPress(object sender, ActionButtonPressEventArgs e)
        {
            try
            {
                switch (e.Index)
                {
                    case 0:
                        //入库
                        switch (Status)
                        {
                            case 2:
                                throw new Exception("入库已完成！");
                            case 0:
                            case 1:
                                frmAssIn frmAssIn = new frmAssIn
                                {
                                    POID = POID,
                                    IsFromPO = true
                                };
                                Show(frmAssIn, (MobileForm sender1, object args) =>
                                {
                                    if (frmAssIn.ShowResult == ShowResult.Yes)
                                    {
                                        Bind();
                                    }
                                });
                                break;
                        }
                        break;
                    case 1:
                        //退货
                        switch (Status)
                        {
                            case 0:
                                throw new Exception("入库未开始,无法退货！");
                            case 2:
                            case 1:
                                frmAssReturn frmAssReturn = new frmAssReturn
                                {
                                    POID = POID,
                                    IsFromPO = true
                                };
                                Show(frmAssReturn, (MobileForm sender1, object args) =>
                                {
                                    if (frmAssReturn.ShowResult == ShowResult.Yes)
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
                var po = _autofacConfig.AssPurchaseOrderService.GetById(POID);
                lblName.Text = po.NAME;
                lblPMan.Text = po.PURCHASERNAME;
                lblRealId.Text = po.REALID;
                lblStatus.Tag = po.STATUS;
                lblVendor.Text = po.VNAME;
                lblTID.Text = POID;
                Status = po.STATUS;
                switch (po.STATUS)
                {
                    case 1:
                        lblStatus.Text = "入库中";
                        break;
                    case 2:
                        lblStatus.Text = "已完成";
                        break;
                    case 0:
                        lblStatus.Text = "采购中";
                        break;
                }
                var row = _autofacConfig.AssPurchaseOrderService.GetRows(POID);
                if (row.Rows.Count > 0)
                {
                    lvPORow.DataSource = row;
                    lvPORow.DataBind();
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
        private void frmAssPurchaseOrderResult_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
        }
    }
}