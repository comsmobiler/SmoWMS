using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.Layout;
using SMOWMS.Domain.Entity;

namespace SMOWMS.UI.MasterData
{
    partial class frmAssetsTypeFirstLevel : Smobiler.Core.Controls.MobileForm
    {
        public frmAssetsTypeFirstLevel() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsTypeFirstLevel_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        internal void Bind()
        {
            List<AssetsType> assetsTypeList= autofacConfig.assTypeService.GetAllFirstLevel();
            if (assetsTypeList.Count > 0)
            {
                lvFirstLevel.DataSource = assetsTypeList;
                lvFirstLevel.DataBind();
            }
            foreach(ListViewRow Row in lvFirstLevel.Rows)
            {
                frmATFirstLevelLayout Layout = Row.Control as frmATFirstLevelLayout;
                svEnable svLayout = ((frmATFirstLevelLayout)Row.Control).svRow.RightControl as svEnable;
                if (Layout.lblNext.BindDataValue.ToString() == "0")
                {
                    svLayout.btnEnable.Text = "启用";
                    svLayout.btnEnable.BackColor = System.Drawing.Color.FromArgb(43, 140, 255);
                    Layout.lblName.ForeColor = System.Drawing.Color.FromArgb(230,230,230);
                }
            }
        }
        /// <summary>
        /// 新增一级分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plAdd_Press(object sender, EventArgs e)
        {
            frmAssetsTypeCreateLayout frm = new frmAssetsTypeCreateLayout();
            frm.plFID.Visible = false;
            frm.plFName.Visible = false;
            frm.plFDate.Visible = false;
            frm.Height = 220;
            frm.isCreate = true;
            ShowDialog(frm, (object sender1, EventArgs e1) => {
                Bind();
            });
        }
    }
}