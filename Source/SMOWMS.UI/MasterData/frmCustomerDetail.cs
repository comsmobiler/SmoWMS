using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.Domain.Entity;
using SMOWMS.CommLib;
using SMOWMS.DTOs.Enum;

namespace SMOWMS.UI.MasterData
{
    partial class frmCustomerDetail : Smobiler.Core.Controls.MobileForm
    {
        public frmCustomerDetail() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        internal int cusId;    //客户编号
        internal int vId;      //供货商编号
        internal UnitType unitType;      //单位类型
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCustomerDetail_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        private void Bind()
        {
            switch (unitType)
            {
                case UnitType.客户:
                    Customer customer = autofacConfig.customerService.GetById(cusId);
                    lblName.Text = customer.NAME;
                    lblContacts.Text = customer.CONTACTS;
                    lblPhone.Text = customer.PHONE;
                    lblAddress.Text = customer.ADDRESS;
                    lblFax.Text = customer.FAX;
                    lblEmail.Text = customer.EMAIL;
                    lblTaxNumber.Text = customer.TAXNUMBER;
                    lblBank.Text = customer.BANK;
                    lblAccount.Text = customer.ACCOUNT;
                    lblNote.Text = customer.NOTE;
                    break;
                case UnitType.供应商:
                    title1.TitleText = "供货商详情";
                    Vendor vendor = autofacConfig.vendorService.GetById(vId);
                    lblName.Text = vendor.NAME;
                    lblContacts.Text = vendor.CONTACTS;
                    lblPhone.Text = vendor.PHONE;
                    lblAddress.Text = vendor.ADDRESS;
                    lblFax.Text = vendor.FAX;
                    lblEmail.Text = vendor.EMAIL;
                    lblTaxNumber.Text = vendor.TAXNUMBER;
                    lblBank.Text = vendor.BANK;
                    lblAccount.Text = vendor.ACCOUNT;
                    lblNote.Text = vendor.NOTE;
                    break;
            }           
        }
        /// <summary>
        /// 客户/供货商编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Press(object sender, EventArgs e)
        {
            frmCustomerCreate frmCustomerCreate = new frmCustomerCreate();
            frmCustomerCreate.unitType = unitType;
            switch (unitType)
            {
                case UnitType.客户:
                    frmCustomerCreate.cusId = cusId;
                    break;
                case UnitType.供应商:
                    frmCustomerCreate.vId = vId;
                    break;
            }
            Show(frmCustomerCreate, (MobileForm sender1, Object args) => {
                if (frmCustomerCreate.ShowResult == ShowResult.Yes)
                {
                    Bind();
                }
            });
        }
        /// <summary>
        /// 客户删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Press(object sender, EventArgs e)
        {
            switch (unitType)
            {
                case UnitType.客户:
                    MessageBox.Show("你确定要删除该客户吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                    {
                        try
                        {
                            if (args.Result == ShowResult.OK)     //启用该仓库
                            {
                                ReturnInfo rInfo = autofacConfig.customerService.DeleteCustomer(cusId);
                                if (rInfo.IsSuccess)
                                {
                                    Toast("删除客户成功");
                                    Close();
                                }
                                else
                                {
                                    throw new Exception(rInfo.ErrorInfo);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Form.Toast(ex.Message);
                        }
                    });
                    break;
                case UnitType.供应商:
                    MessageBox.Show("你确定要删除该供应商吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                    {
                        try
                        {
                            if (args.Result == ShowResult.OK)     //启用该仓库
                            {
                                ReturnInfo rInfo = autofacConfig.vendorService.DeleteVendor(vId);
                                if (rInfo.IsSuccess)
                                {
                                    Toast("删除供应商成功");
                                    Close();
                                }
                                else
                                {
                                    throw new Exception(rInfo.ErrorInfo);
                                }
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