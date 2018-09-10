using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.AssetsManager;
using SMOWMS.UI.ConsumablesManager;
using System.Data;
using SMOWMS.UI.Layout;
using System.Drawing;

namespace SMOWMS.UI.Menu
{
    partial class frmOrder : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        internal int type = 0;   // 0-资产,1-耗材
        internal int orderType=0;     //0-采购订单,1-销售订单
        #endregion
        public frmOrder() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOrder_Load(object sender, EventArgs e)
        {
            // 设置菜单栏默认选中项
            menuToolbar.SelectedIndex = 1;

            string UserId = Session["UserID"].ToString();   //当前用户

            Bind(type,orderType);
        }
        /// <summary>
        /// 切换资产显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAss_Press(object sender, EventArgs e)
        {
            if(type == 1)
            {
                btnAss.BackColor = Color.White;
                btnAss.ForeColor = Color.Black;
                btnCon.BackColor = Color.FromArgb(230, 230, 230);
                btnCon.ForeColor = Color.DarkGray;
                type = 0;  //资产
                Bind(type,orderType);
            }
        }
        /// <summary>
        /// 切换耗材显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCon_Press(object sender, EventArgs e)
        {
            if (type == 0)
            {
                btnCon.BackColor = Color.White;
                btnCon.ForeColor = Color.Black;
                btnAss.BackColor = Color.FromArgb(230, 230, 230);
                btnAss.ForeColor = Color.DarkGray;
                type = 1;  //耗材
                Bind(type,orderType);
            }
        }
        /// <summary>
        /// 切换采购和销售单据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (scType.SelectedIndex != orderType)
            {
                orderType = scType.SelectedIndex;
                Bind(type,orderType);
            }
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        public void Bind(int datType,int orderType)
        {
            try
            {
                if (plAllData.Controls.Count > 1)
                {
                    plAllData.Controls.RemoveAt(1);
                }
                switch (datType)
                {
                    case 0:    //资产
                        if(orderType == 0)      //资产采购
                        {
                            ListView lvData = GetListView();
                            lvData.TemplateControlName = "frmAssPOLayout";
                            plAllData.Controls.Add(lvData);
                            DataTable asspoList = autofacConfig.AssPurchaseOrderService.GetOrders("");
                            lvData.DataSource = asspoList;
                            lvData.DataBind();
                            foreach (var row in lvData.Rows)
                            {
                                frmAssPOLayout layout = (frmAssPOLayout)row.Control;
                                switch (layout.lblStatus.Text)
                                {
                                    case "已完成":
                                        layout.lblStatus.ForeColor = Color.FromArgb(43, 125, 43);
                                        layout.ibEdit.Visible = false;
                                        break;
                                    case "入库中":
                                        layout.lblStatus.ForeColor = Color.FromArgb(43, 140, 255);
                                        layout.ibEdit.Visible = false;
                                        break;
                                    case "采购中":
                                        layout.lblStatus.ForeColor = Color.FromArgb(211, 215, 217);
                                        break;
                                }                               
                            }
                        }
                        else      //资产销售
                        {
                            ListView lvData = GetListView();
                            lvData.TemplateControlName = "frmAssSOLayout";
                            plAllData.Controls.Add(lvData);
                            DataTable asssoList = autofacConfig.AssSalesOrderService.GetOrders("");
                            lvData.DataSource = asssoList;
                            lvData.DataBind();
                            foreach (var row in lvData.Rows)
                            {
                                frmAssSOLayout layout = (frmAssSOLayout)row.Control;
                                switch (layout.lblStatus.Text)
                                {
                                    case "已完成":
                                        layout.lblStatus.ForeColor = Color.FromArgb(43, 125, 43);
                                        layout.ibEdit.Visible = false;
                                        break;
                                    case "出库中":
                                        layout.lblStatus.ForeColor = Color.FromArgb(43, 140, 255);
                                        layout.ibEdit.Visible = false;
                                        break;
                                    case "销售中":
                                        layout.lblStatus.ForeColor = Color.FromArgb(211, 215, 217);
                                        break;
                                }
                            }
                        }                      
                        break;
                    case 1:    //耗材
                        if (orderType == 0)  //耗材采购
                        {
                            ListView lvData = GetListView();
                            lvData.TemplateControlName = "frmConPurchaseLayout";
                            plAllData.Controls.Add(lvData);

                            DataTable purchaseOrder = autofacConfig.ConPurchaseOrderService.GetOrders();
                            lvData.DataSource = purchaseOrder;
                            lvData.DataBind();
                            foreach (ListViewRow Row in lvData.Rows)
                            {
                                frmConPurchaseLayout layout = (frmConPurchaseLayout)Row.Control;
                                switch (layout.lblStatus.Text)
                                {
                                    case "已完成":
                                        layout.lblStatus.ForeColor = Color.FromArgb(43, 125, 43);
                                        layout.ibEdit.Visible = false;
                                        break;
                                    case "入库中":
                                        layout.lblStatus.ForeColor = Color.FromArgb(43, 140, 255);
                                        layout.ibEdit.Visible = false;
                                        break;
                                    case "采购中":
                                        layout.lblStatus.ForeColor = Color.FromArgb(211, 215, 217);
                                        break;
                                }
                            }
                        }
                        else      //耗材销售
                        {
                            ListView lvData = GetListView();
                            lvData.TemplateControlName = "frmConSalesLayout";
                            plAllData.Controls.Add(lvData);

                            DataTable salesOrders = autofacConfig.ConSalesOrderService.GetOrders();
                            lvData.DataSource = salesOrders;
                            lvData.DataBind();
                            foreach (ListViewRow Row in lvData.Rows)
                            {
                                frmConSalesLayout layout = (frmConSalesLayout)Row.Control;
                                switch (layout.lblStatus.Text)
                                {
                                    case "已完成":
                                        layout.lblStatus.ForeColor = Color.FromArgb(43, 125, 43);
                                        layout.ibEdit.Visible = false;
                                        break;
                                    case "出库中":
                                        layout.lblStatus.ForeColor = Color.FromArgb(43, 140, 255);
                                        layout.ibEdit.Visible = false;
                                        break;
                                    case "销售中":
                                        layout.lblStatus.ForeColor = Color.FromArgb(211, 215, 217);
                                        break;
                                }
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        public ListView GetListView()
        {
            ListView lvData = new ListView();      //单据列表
            lvData.ShowSplitLine = true;
            lvData.SplitLineColor = Color.FromArgb(230, 230, 230);
            lvData.Width = 260;
            lvData.Height = 0;
            return lvData;
        }
        /// <summary>
        /// 手机自带返回键操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOrder_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Client.Exit();
        }
        /// <summary>
        /// 各种单据新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOrder_ActionButtonPress(object sender, ActionButtonPressEventArgs e)
        {
            switch (e.Index)
            {
                case 0:       //资产采购创建
                    frmAssPurchaseOrderCreate frmAssPurchaseOrderCreate = new frmAssPurchaseOrderCreate();
                    Show(frmAssPurchaseOrderCreate, (MobileForm senderAP, object args)=> {
                        Bind(type,orderType);
                    });
                    break;
                case 1:      //资产销售创建
                    frmAssSalesOrderCreate frmAssSalesOrderCreate = new frmAssSalesOrderCreate();
                    Show(frmAssSalesOrderCreate, (MobileForm senderAS, object args) => {
                        Bind(type, orderType);
                    });
                    break;
                case 2:      //耗材采购创建
                    frmConPurchaseCreate frmConPurchaseCreate = new frmConPurchaseCreate();
                    Show(frmConPurchaseCreate, (MobileForm senderCP, object args) => {
                        Bind(type, orderType);
                    });
                    break;
                case 3:      //耗材销售创建
                    frmConSalesCreate frmConSalesCreate = new frmConSalesCreate();
                    Show(frmConSalesCreate, (MobileForm senderCS, object args) => {
                        Bind(type, orderType);
                    });
                    break;
            }
        }
    }
}