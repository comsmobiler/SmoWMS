using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.OutputDTO;
using SMOWMS.UI.Layout;

namespace SMOWMS.UI.MasterData
{
    partial class frmWHStorageLocation : Smobiler.Core.Controls.MobileForm
    {
        public frmWHStorageLocation() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        internal String WAREID;              //仓库编号
        internal String STID;                //存储类型编号
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWHStorageLocation_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        internal void Bind()
        {
            WHStorageTypeOutputDto wHStorageTypeOutputDto = autofacConfig.wareHouseService.GetSTByWareIDandSTID(WAREID,STID);
            title1.TitleText = wHStorageTypeOutputDto.NAME;

            List<WHStorageLocation> WHSLlist = autofacConfig.wareHouseService.GetSLByWareIDAndSTID(WAREID, STID);
            if (WHSLlist.Count > 0)
            {
                lvWHStorageLocation.DataSource = WHSLlist;
                lvWHStorageLocation.DataBind();
            }
            foreach (ListViewRow Row in lvWHStorageLocation.Rows)
            {
                frmWHSLLayout Layout = Row.Control as frmWHSLLayout;
                svEnable svLayout = ((frmWHSLLayout)Row.Control).svRow.RightControl as svEnable;
                if (Layout.ibEdit.BindDataValue.ToString() == "0")
                {
                    svLayout.btnEnable.Text = "启用";
                    svLayout.btnEnable.BackColor = System.Drawing.Color.FromArgb(43, 140, 255);
                    Layout.lblName.ForeColor = System.Drawing.Color.FromArgb(230, 230, 230);
                }
            }
        }
        /// <summary>
        /// 编辑当前存储类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plEdit_Press(object sender, EventArgs e)
        {
            DialogOptions dialog = new DialogOptions
            {
                JustifyAlign = LayoutJustifyAlign.Center,
                Padding = new Padding(0)
            };
            frmSTCreateLayout frmSt = new frmSTCreateLayout
            {
                isCreate = false,
                isEdit = true,
                WareID = WAREID,
                STID = STID
            };
            ShowDialog(frmSt, dialog);
        }
        /// <summary>
        /// 新增当前存储类型下库位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plAdd_Press(object sender, EventArgs e)
        {
            frmSLCreateLayout frmSl = new frmSLCreateLayout
            {
                isCreate = true,
                isEdit = false,
                WareID = WAREID,
                STID = STID
            };
            ShowDialog(frmSl);
        }
    }
}