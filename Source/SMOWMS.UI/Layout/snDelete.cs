using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.UI.AssetsManager;
using SMOWMS.UI.Menu;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class snDelete : Smobiler.Core.Controls.MobileUserControl
    {
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        public snDelete() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void btnDelRow_Press(object sender, EventArgs e)
        {
            switch (Parent.Parent.Form.ToString())
            {
                case "SMOWMS.UI.AssetsManager.frmAssIn":
                    MessageBox.Show("你确定要删除该序列号吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                    {
                        try
                        {
                            if (args.Result == ShowResult.OK)     //删除序列号
                            {
                                ((frmAssIn)Form).RemoveSN(((SNRowLayout)Parent.Parent).label1.Text);
                            }
                        }
                        catch (Exception ex)
                        {
                            Form.Toast(ex.Message);
                        }
                    });
                    break;
                case "SMOWMS.UI.AssetsManager.frmAssOut":
                    MessageBox.Show("你确定要刪除该序列号吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                    {
                        try
                        {
                            if (args.Result == ShowResult.OK)     //删除序列号
                            {
                                ((frmAssOut)Form).RemoveSN(((SNRowLayout)Parent.Parent).label1.Text);
                            }
                        }
                        catch (Exception ex)
                        {
                            Form.Toast(ex.Message);
                        }
                    });
                    break;
                case "SMOWMS.UI.AssetsManager.frmAssRetiring":
                    MessageBox.Show("你确定要删除该序列号吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                    {
                        try
                        {
                            if (args.Result == ShowResult.OK)     //删除序列号
                            {
                                ((frmAssRetiring)Form).RemoveSN(((SNRowLayout)Parent.Parent).label1.Text);
                            }
                        }
                        catch (Exception ex)
                        {
                            Form.Toast(ex.Message);
                        }
                    });
                    break;
                case "SMOWMS.UI.AssetsManager.frmAssReturn":
                    MessageBox.Show("你确定要删除该序列号吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                    {
                        try
                        {
                            if (args.Result == ShowResult.OK)     //删除序列号
                            {
                                ((frmAssReturn)Form).RemoveSN(((SNRowLayout)Parent.Parent).label1.Text);
                            }
                        }
                        catch (Exception ex)
                        {
                            Form.Toast(ex.Message);
                        }
                    });
                    break;
            }
        }
    }
}