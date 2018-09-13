using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.MasterData;
using SMOWMS.DTOs.Enum;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmCustomerLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public frmCustomerLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        /// <summary>
        /// 客户编号
        /// </summary>
        internal int cusId
        {
            get
            {
                return Convert.ToInt32(lblName.BindDataValue);
            }
        }
        /// <summary>
        /// 跳转到拨打电话界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plCall_Press(object sender, EventArgs e)
        {
            Client.TelCall(lblPhone.Text);
        }
        /// <summary>
        /// 点击查看客户详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plRow_Press(object sender, EventArgs e)
        {
            frmCustomerDetail frmCusDetail = new frmCustomerDetail();
            frmCusDetail.cusId = Convert.ToInt32(lblName.BindDataValue);
            frmCusDetail.unitType = ((frmCustomer)Form).unitType;
            Form.Show(frmCusDetail, (MobileForm sender1, object args) => {
                ((frmCustomer)Form).Bind();
            });
        }
    }
}