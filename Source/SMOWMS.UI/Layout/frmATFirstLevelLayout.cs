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
    partial class frmATFirstLevelLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public frmATFirstLevelLayout() : base()
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
        /// 类型编号
        /// </summary>
        internal string TYPEID
        {
            get
            {
                return lblName.BindDataValue.ToString();
            }
        }
        /// <summary>
        /// 点击查看子类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plRow_Press(object sender, EventArgs e)
        {
            if (Form.ToString() == "SMOWMS.UI.MasterData.frmAssetsTypeSecondLevel")
            {
                frmAssetsTypeThirdLevel frmThirdLevel = new frmAssetsTypeThirdLevel();
                frmThirdLevel.ID = lblName.BindDataValue.ToString();
                Form.Show(frmThirdLevel, (MobileForm sender1, object args) =>
                {
                    ((frmAssetsTypeSecondLevel)Form).Bind();       //页面刷新
                });
            }
            else
            {
                frmAssetsTypeSecondLevel frmSecondLevel = new frmAssetsTypeSecondLevel();
                frmSecondLevel.ID = lblName.BindDataValue.ToString();
                Form.Show(frmSecondLevel, (MobileForm sender1, object args) =>
                {
                    ((frmAssetsTypeFirstLevel)Form).Bind();       //页面刷新
                });
            }
        }
    }
}