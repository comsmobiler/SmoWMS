using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.Domain.Entity;
using SMOWMS.UI.Layout;

namespace SMOWMS.UI.MasterData
{
    partial class frmAssetsTypeSecondLevel : Smobiler.Core.Controls.MobileForm
    {
        public frmAssetsTypeSecondLevel() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        internal String ID;              //选择资产分类编号
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsTypeSecondLevel_Load(object sender, EventArgs e)
        {         
            Bind();
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        internal void Bind()
        {
            AssetsType assetsType = autofacConfig.assTypeService.GetByID(ID);
            title1.TitleText = assetsType.NAME;

            List<AssetsType> assetsTypeList=autofacConfig.assTypeService.GetByLevelAndParentId(2,ID);
            if (assetsTypeList.Count > 0)
            {
                lvSecondLevel.DataSource = assetsTypeList;
                lvSecondLevel.DataBind();
            }
            foreach (ListViewRow Row in lvSecondLevel.Rows)
            {
                frmATFirstLevelLayout Layout = Row.Control as frmATFirstLevelLayout;
                svEnable svLayout = ((frmATFirstLevelLayout)Row.Control).svRow.RightControl as svEnable;
                if (Layout.lblNext.BindDataValue.ToString() == "0")
                {
                    svLayout.btnEnable.Text = "启用";
                    svLayout.btnEnable.BackColor = System.Drawing.Color.FromArgb(43, 140, 255);
                    Layout.lblName.ForeColor = System.Drawing.Color.FromArgb(230, 230, 230);
                }
            }
        }
        /// <summary>
        /// 添加二级分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plAdd_Press(object sender, EventArgs e)
        {
            frmAssetsTypeCreateLayout frm = new frmAssetsTypeCreateLayout();
            frm.isCreateSon = true;
            frm.ID = ID;
            ShowDialog(frm, (object sender1, EventArgs e1) => {
                Bind();
            });
        }
        /// <summary>
        /// 编辑当前一级分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plEdit_Press(object sender, EventArgs e)
        {
            frmAssetsTypeCreateLayout frm = new frmAssetsTypeCreateLayout();
            frm.plFID.Visible = false;
            frm.plFName.Visible = false;
            frm.plFDate.Visible = false;
            frm.Height = 220;
            frm.ID = ID;      //类别编码
            frm.isEdit = true;     //编辑状态
            ShowDialog(frm, (object sender1, EventArgs e1) => {
                Bind();
            });
        }
    }
}