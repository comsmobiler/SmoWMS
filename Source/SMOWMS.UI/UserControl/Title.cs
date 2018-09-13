using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.ComponentModel;

namespace SMOWMS.UI.UserControl
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    [System.ComponentModel.ToolboxItem(true)]
    partial class Title : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 标题内容
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(""), Description("标题")]
        public string TitleText
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;

            }
        }
        /// <summary>
        /// 标题字体大小
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(""), Description("标题字体大小")]
        public float FontSize
        {
            get
            {
                return this.label1.FontSize;
            }
            set
            {
                this.label1.FontSize = value;

            }
        }
        /// <summary>
        /// 文本颜色
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(""), Description("文本颜色")]
        public System.Drawing.Color ForeColor
        {
            get
            {
                return this.label1.ForeColor;
            }
            set
            {
                this.label1.ForeColor = value;

            }
        }
        /// <summary>
        /// 返回事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel1_Press(object sender, EventArgs e)
        {
            this.Form.Close();
        }
    }
}