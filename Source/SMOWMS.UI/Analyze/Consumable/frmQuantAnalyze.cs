using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using SMOWMS.Domain.Entity;

namespace SMOWMS.UI.Analyze.Consumable
{
    partial class frmQuantAnalyze : Smobiler.Core.Controls.MobileForm
    {
        public frmQuantAnalyze() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmQuantAnalyze_Load(object sender, EventArgs e)
        {
            //仓库赋值
            popWareHouse.Groups.Clear();       //数据清空
            PopListGroup poliWH = new PopListGroup();
            popWareHouse.Groups.Add(poliWH);
            poliWH.AddListItem("全部仓库", null);
            List<WareHouse> wareHouseList = autofacConfig.wareHouseService.GetAllWareHouse();
            foreach (WareHouse Row in wareHouseList)
            {
                poliWH.AddListItem(Row.NAME, Row.WAREID);
            }
            popWareHouse.SetSelections(popWareHouse.Groups[0].Items[0]);

            Bind();
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        public void Bind()
        {
            String wareId = btnWareHouse.Tag == null ? null : btnWareHouse.Tag.ToString();
            Dictionary<string, decimal> result = autofacConfig.consumablesService.GetQuantAnalyse(wareId);
            DataTable table = new DataTable();
            table.Columns.Add("NAME");        //耗材名称
            table.Columns.Add("QUANTITY");    //耗材库存
            foreach (string name in result.Keys)
            {
                table.Rows.Add(name, result[name]);
            }
            bcQuant.DataSource = table;
            bcQuant.DataBind();

        }
        /// <summary>
        /// 选择仓库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWareHouse_Press(object sender, EventArgs e)
        {
            if (btnWareHouse.Tag != null)   //如果已有选中项，则显示选中效果
            {
                foreach (PopListItem Item in popWareHouse.Groups[0].Items)
                {
                    if (Item.Value == btnWareHouse.Tag.ToString())
                        popWareHouse.SetSelections(Item);
                }
            }
            popWareHouse.ShowDialog();
        }
        /// <summary>
        /// 仓库选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popWareHouse_Selected(object sender, EventArgs e)
        {
            if (popWareHouse.Selection != null)
            {
                btnWareHouse.Text = popWareHouse.Selection.Text + "   > ";
                btnWareHouse.Tag = popWareHouse.Selection.Value;
                Bind();
            }
        }
    }
}