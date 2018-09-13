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
    partial class frmWHLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public frmWHLayout() : base()
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
        /// 仓库编号
        /// </summary>
        internal string WAREID
        {
            get
            {
                return lblName.BindDataValue.ToString();
            }
        }
        /// <summary>
        /// 跳转到点击仓库下存储类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plRow_Press(object sender, EventArgs e)
        {
            frmWHStorgageType frmWHStorgageType = new frmWHStorgageType();
            frmWHStorgageType.WAREID = lblName.BindDataValue.ToString();
            Form.Show(frmWHStorgageType, (MobileForm sender1, object args) =>
            {
                ((frmWH)Form).Bind();       //页面刷新
            });
        }
    }
}