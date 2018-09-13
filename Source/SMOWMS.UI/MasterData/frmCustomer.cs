using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;

namespace SMOWMS.UI.MasterData
{
    partial class frmCustomer : Smobiler.Core.Controls.MobileForm
    {
        public frmCustomer() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        internal UnitType unitType;      //单位类别
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            switch (unitType)
            {
                case UnitType.客户:
                    ActionButton.Items[0].Text = "新增客户";
                    title1.TitleText = "客户列表";
                    break;
                case UnitType.供应商:
                    ActionButton.Items[0].Text = "新增供货商";
                    title1.TitleText = "供应商列表";
                    break;
            }
            Bind();
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        internal void Bind()
        {
            switch (unitType)
            {
                case UnitType.客户:
                    lvCumtomer.TemplateControlName = "frmCustomerLayout";
                    List<Customer> customerList = new List<Customer>();
                    if (!String.IsNullOrEmpty(txtName.Text))
                    {
                        customerList = autofacConfig.customerService.GetByKeyword(txtName.Text);
                    }
                    else
                    {
                        customerList = autofacConfig.customerService.GetAll();
                    }
                    lvCumtomer.DataSource = customerList;
                    lvCumtomer.DataBind();
                    break;
                case UnitType.供应商:
                    lvCumtomer.TemplateControlName = "frmVendorLayout";
                    List<Vendor> vendorList = new List<Vendor>();
                    if (!String.IsNullOrEmpty(txtName.Text))
                    {
                        vendorList = autofacConfig.vendorService.GetByKeyword(txtName.Text);
                    }
                    else
                    {
                        vendorList = autofacConfig.vendorService.GetAll();
                    }
                    lvCumtomer.DataSource = vendorList;
                    lvCumtomer.DataBind();
                    break;
            }         
        }
        /// <summary>
        /// 关键词搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 客户新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCustomer_ActionButtonPress(object sender, ActionButtonPressEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    frmCustomerCreate frmCustomerCreate = new frmCustomerCreate();
                    frmCustomerCreate.unitType = unitType;
                    Show(frmCustomerCreate, (MobileForm sender1, object args) =>
                    {
                        if (frmCustomerCreate.ShowResult == ShowResult.Yes)
                        {
                            Bind();    //新增客户完毕，刷新当前界面
                        }
                    });
                    break;
            }
        }
    }
}