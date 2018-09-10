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
    partial class frmATThirdLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public frmATThirdLayout() : base()
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
        /// 类型编号
        /// </summary>
        internal string TYPEID
        {
            get
            {
                return lblName.BindDataValue.ToString() ;
            }
        }
        /// <summary>
        /// 编辑当前分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibEdit_Press(object sender, EventArgs e)
        {
            frmAssetsTypeCreateLayout frm = new frmAssetsTypeCreateLayout();
            frm.ID = lblName.BindDataValue.ToString();      //类别编码
            frm.isEdit = true;     //编辑状态
            this.Form.ShowDialog(frm, (object sender1, EventArgs e1) =>
            {
                ((frmAssetsTypeThirdLevel)Form).Bind();
            });
        }
    }
}