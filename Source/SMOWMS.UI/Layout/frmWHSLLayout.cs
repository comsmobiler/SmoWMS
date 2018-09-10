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
    partial class frmWHSLLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public frmWHSLLayout() : base()
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
                return Convert.ToInt32(ibEdit.BindDataValue.ToString());
            }
        }
        /// <summary>
        /// 库位编号
        /// </summary>
        internal string SLID
        {
            get
            {
                return lblName.BindDataValue.ToString();
            }
        }
        /// <summary>
        /// 编辑当前库位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibEdit_Press(object sender, EventArgs e)
        {
            DialogOptions dialog = new DialogOptions
            {
                JustifyAlign = LayoutJustifyAlign.Center,
                Padding = new Padding(0)
            };
            frmSLCreateLayout frmSl = new frmSLCreateLayout
            {
                isCreate = false,
                isEdit = true,
                WareID = ((frmWHStorageLocation)Form).WAREID,
                STID = ((frmWHStorageLocation)Form).STID,
                SLID = lblName.BindDataValue.ToString()
            };
            ShowDialog(frmSl, dialog, (object sender1, EventArgs e1)=> {
                ((frmWHStorageLocation)Form).Bind();
            });
        }
    }
}