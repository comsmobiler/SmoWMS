using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.MasterData;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmVendorLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public frmVendorLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        /// <summary>
        /// 供应商编号
        /// </summary>
        internal int vId
        {
            get
            {
                return Convert.ToInt32(lblName.BindDataValue);
            }
        }
        /// <summary>
        /// 拨打电话
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plCall_Press(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblPhone.Text))
            {
                Client.TelCall(lblPhone.Text);
            }       
        }
        /// <summary>
        /// 点击查看供应商详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plRow_Press(object sender, EventArgs e)
        {
            frmCustomerDetail frmCusDetail = new frmCustomerDetail();
            frmCusDetail.vId = Convert.ToInt32(lblName.BindDataValue);
            frmCusDetail.unitType = ((frmCustomer)Form).unitType;
            Form.Show(frmCusDetail, (MobileForm sender1, object args) => {
                ((frmCustomer)Form).Bind();
            });
        }
    }
}