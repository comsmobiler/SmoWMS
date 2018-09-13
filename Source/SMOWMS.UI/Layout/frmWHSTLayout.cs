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
    partial class frmWHSTLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public frmWHSTLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        /// <summary>
        /// 启用/禁用
        /// </summary>
        internal int ISENABLE
        {
            get
            {
                return Convert.ToInt32(lblNext.BindDataValue.ToString());
            }
        }
        /// <summary>
        /// 存储类型编号
        /// </summary>
        internal string STID
        {
            get
            {
                return lblName.BindDataValue.ToString();
            }
        }
        /// <summary>
        /// 跳转到当前类型下库位列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plRow_Press(object sender, EventArgs e)
        {
            frmWHStorageLocation frmWHStorageLocation = new frmWHStorageLocation();
            frmWHStorageLocation.WAREID = ((frmWHStorgageType)Form).WAREID;
            frmWHStorageLocation.STID = lblName.BindDataValue.ToString();
            Form.Show(frmWHStorageLocation, (MobileForm sender1, object args) =>
            {
                ((frmWHStorgageType)Form).Bind();       //页面刷新
            });
        }
    }
}