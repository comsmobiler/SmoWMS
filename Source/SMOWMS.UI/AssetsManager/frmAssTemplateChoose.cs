using System;
using System.Collections.Generic;
using System.Data;
using Smobiler.Core.Controls;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.UI.Layout;

namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssTemplateChoose : Smobiler.Core.Controls.MobileForm
    {
        #region 变量
        public DataTable AllATTable = new DataTable();

        public string UserId;

        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private DataTable ATShow=new DataTable();

        public List<AssRowInputDto> Rows=new List<AssRowInputDto>();

        private string errorInfo;
        #endregion

        /// <summary>
        /// 改变全选的状态时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkall_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Checkall.Checked)
                {
                    foreach (var row in lvAssTemplate.Rows)
                    {
                        frmATChooseLayout ATRow = (frmATChooseLayout)row.Control;
                        ATRow.CheckBox1.Checked = true;
                    }

                }
                
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 按确定时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                errorInfo = "";
                GetAT();
                if (string.IsNullOrEmpty(errorInfo))
                {
                    if (Rows.Count == 0)
                    {
                        throw new Exception("请选择行项！");
                    }
                    else
                    {
                        ShowResult = ShowResult.Yes;
                        Close();
                    }

                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


        /// <summary>
        /// 界面初始化时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssTemplateChoose_Load(object sender, EventArgs e)
        {
            try
            {
                AllATTable = _autofacConfig.SettingService.GetAllAssTemps();
                foreach (DataRow row in AllATTable.Rows)
                {
                    string TId = row["TEMPLATEID"].ToString();
                    AssRowInputDto inputDto = Rows.Find(a => a.TEMPLATEID == TId);
                    if (inputDto != null)
                    {
                        row["IsChecked"] = true;
                        row["PRICE"] = inputDto.PRICE;
                        row["QUANT"] = inputDto.QUANT;
                    }
                }
                DataColumn[] keys = new DataColumn[1];
                keys[0] = AllATTable.Columns["TEMPLATEID"];
                AllATTable.PrimaryKey = keys;

                UserId = Client.Session["UserID"].ToString();
                Bind(null);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 按回退，则关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssTemplateChoose_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Close();
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        /// <param name="name"></param>
        private void Bind(string name)
        {
            try
            {
                ATShow = _autofacConfig.SettingService.QueryAssTemplate(name);

                foreach (DataRow row in ATShow.Rows)
                {

                    string TId = row["TEMPLATEID"].ToString();
                    DataRow allATRow = AllATTable.Rows.Find(TId);
                    if (allATRow != null)
                    {
                        row["IsChecked"] = allATRow["IsChecked"];
                        row["PRICE"] = allATRow["PRICE"];
                        row["QUANT"] = allATRow["QUANT"];
                    }
                }

                if (ATShow.Rows.Count > 0)
                {
                    lvAssTemplate.DataSource = ATShow;
                    lvAssTemplate.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        /// <summary>
        /// 得到行项数据
        /// </summary>
        private void GetAT()
        {
            try
            {
                //先保存当前页数据
                GetRow();

                //从AllATTale获取所需数据

                Rows.Clear();

                foreach (DataRow row in AllATTable.Rows)
                {
                    AssRowInputDto rowInputDto =new AssRowInputDto();
                    if (bool.Parse(row["IsChecked"].ToString()))
                    {
                        rowInputDto.TEMPLATEID = row["TEMPLATEID"].ToString();
                        rowInputDto.IMAGE = row["IMAGE"].ToString();
                        rowInputDto.QUANT = decimal.Parse(row["QUANT"].ToString());
                        rowInputDto.NAME = row["NAME"].ToString();
                        rowInputDto.PRICE = decimal.Parse(row["PRICE"].ToString());
                        if (rowInputDto.QUANT == 0 ||rowInputDto.PRICE == 0)
                        {
                            errorInfo = "请保证行项中的数量和单价均不为0！";
                            throw new Exception("请保证行项中的数量和单价均不为0！");
                        }
                        
                        //                        rowInputDto.TPRICE = decimal.Parse(row["TPRICE"].ToString());

                        Rows.Add(rowInputDto);
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }




        }

        /// <summary>
        /// 得到行项数据
        /// </summary>
        private void GetRow()
        {
            try
            {
                foreach (var row in lvAssTemplate.Rows)
                {
                    frmATChooseLayout ATRow = (frmATChooseLayout)row.Control;
                    //更新对应的AllATTale行项
                    string TId = ATRow.LblTId.Text;
                    DataRow allATRow = AllATTable.Rows.Find(TId);
                    if (allATRow != null)
                    {
                        decimal Quantity;
                        if (decimal.TryParse(ATRow.numQuant.Value.ToString(), out Quantity) == false)
                        {
                            throw new Exception("模板" + ATRow.LblTId.Text + "的计划数量格式不正确。");
                        }
                        decimal PRICE;
                        if (decimal.TryParse(ATRow.numPrice.Value.ToString(), out PRICE) == false)
                        {
                            throw new Exception("模板" + ATRow.LblTId.Text + "的计划单价格式不正确。");
                        }
                        allATRow["IsChecked"] = ATRow.CheckBox1.Checked;
                        allATRow["PRICE"] = PRICE;
                        allATRow["QUANT"] = Quantity;
//                        if (Quantity != 0 && PRICE != 0)
//                        {
//                            allATRow["IsChecked"] = ATRow.CheckBox1.Checked;
//                            allATRow["PRICE"] = PRICE;
//                            allATRow["QUANT"] = Quantity;
//                        }
//                        else
//                        {
//                            errorInfo = "请保证行项中的数量和单价均不为0！";
//                            throw new Exception("请保证行项中的数量和单价均不为0！");
//                        }
                    }

                    
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 改变文字时，执行查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GetRow();
                Bind(txtName.Text);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}