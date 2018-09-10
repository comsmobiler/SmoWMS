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
    partial class frmCustomerCreate : Smobiler.Core.Controls.MobileForm
    {
        public frmCustomerCreate() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        internal int cusId;        //客户编号
        internal int vId;      //供货商编号
        internal UnitType unitType;      //单位类型
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCustomerCreate_Load(object sender, EventArgs e)
        {
            switch (unitType)
            {
                case UnitType.客户:
                    if (cusId != 0)
                    {
                        title1.TitleText = "客户修改";
                        Customer customer = autofacConfig.customerService.GetById(cusId);
                        txtName.Text = customer.NAME;
                        txtContacts.Text = customer.CONTACTS;
                        txtPhone.Text = customer.PHONE;
                        txtAddress.Text = customer.ADDRESS;
                        txtFax.Text = customer.FAX;
                        txtEmail.Text = customer.EMAIL;
                        txtTaxNumber.Text = customer.TAXNUMBER;
                        txtBank.Text = customer.BANK;
                        txtAccount.Text = customer.ACCOUNT;
                        txtNote.Text = customer.NOTE;
                    }
                    break;
                case UnitType.供应商:
                    if (vId != 0)
                    {
                        title1.TitleText = "供货商修改";
                        Vendor vendor = autofacConfig.vendorService.GetById(vId);
                        txtName.Text = vendor.NAME;
                        txtContacts.Text = vendor.CONTACTS;
                        txtPhone.Text = vendor.PHONE;
                        txtAddress.Text = vendor.ADDRESS;
                        txtFax.Text = vendor.FAX;
                        txtEmail.Text = vendor.EMAIL;
                        txtTaxNumber.Text = vendor.TAXNUMBER;
                        txtBank.Text = vendor.BANK;
                        txtAccount.Text = vendor.ACCOUNT;
                        txtNote.Text = vendor.NOTE;
                    }
                    else
                    {
                        title1.TitleText = "供货商创建";
                    }
                    break;
            }
        }
        /// <summary>
        /// 新增客户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                switch (unitType)
                {
                    case UnitType.客户:
                        if (String.IsNullOrEmpty(txtName.Text)) throw new Exception("单位名称不能为空");
                        Customer customer = new Customer
                        {
                            NAME = txtName.Text,
                            CONTACTS = txtContacts.Text,
                            PHONE = txtPhone.Text,
                            ADDRESS = txtAddress.Text,
                            FAX = txtFax.Text,
                            EMAIL = txtEmail.Text,
                            TAXNUMBER = txtTaxNumber.Text,
                            BANK = txtBank.Text,
                            ACCOUNT = txtAccount.Text,
                            NOTE = txtNote.Text
                        };
                        if (cusId != 0)
                        {
                            customer.CUSID = cusId;
                            ReturnInfo rInfo = autofacConfig.customerService.UpdateCustomer(customer);
                            if (rInfo.IsSuccess)
                            {
                                ShowResult = ShowResult.Yes;
                                Toast("修改客户成功");
                                Close();
                            }
                            else
                            {
                                throw new Exception(rInfo.ErrorInfo);
                            }
                        }
                        else
                        {
                            ReturnInfo rInfo = autofacConfig.customerService.AddCustomer(customer);
                            if (rInfo.IsSuccess)
                            {
                                ShowResult = ShowResult.Yes;
                                Toast("新增客户成功");
                                Close();
                            }
                            else
                            {
                                throw new Exception(rInfo.ErrorInfo);
                            }
                        }
                        break;
                    case UnitType.供应商:
                        if (String.IsNullOrEmpty(txtName.Text)) throw new Exception("单位名称不能为空");
                        Vendor vendor = new Vendor
                        {
                            NAME = txtName.Text,
                            CONTACTS = txtContacts.Text,
                            PHONE = txtPhone.Text,
                            ADDRESS = txtAddress.Text,
                            FAX = txtFax.Text,
                            EMAIL = txtEmail.Text,
                            TAXNUMBER = txtTaxNumber.Text,
                            BANK = txtBank.Text,
                            ACCOUNT = txtAccount.Text,
                            NOTE = txtNote.Text
                        };
                        if (vId != 0)
                        {
                            vendor.VID = vId;
                            ReturnInfo rInfo = autofacConfig.vendorService.UpdateVendor(vendor);
                            if (rInfo.IsSuccess)
                            {
                                ShowResult = ShowResult.Yes;
                                Toast("修改供货商成功");
                                Close();
                            }
                            else
                            {
                                throw new Exception(rInfo.ErrorInfo);
                            }
                        }
                        else
                        {
                            ReturnInfo rInfo = autofacConfig.vendorService.AddVendor(vendor);
                            if (rInfo.IsSuccess)
                            {
                                ShowResult = ShowResult.Yes;
                                Toast("新增供货商成功");
                                Close();
                            }
                            else
                            {
                                throw new Exception(rInfo.ErrorInfo);
                            }
                        }
                        break;
                }               
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}