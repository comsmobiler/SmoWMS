using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.Domain.Entity;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class AssetTypeTree : Smobiler.Core.Controls.MobileUserControl
    {
        public AssetTypeTree() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        public Int32 MaxLevel = 3;         //最深层级
        public Int32 NowLevel = 1;     //当前层级
        public String ID;              //选择资产分类编号
        public string TypeName;
        private bool isFind;
        #endregion

        private void treeAssetType_NodePress(object sender, TreeViewClickEventArgs e)
        {
            try
            {
                ID = e.Value;        //所选资产分类编号
                TypeName = e.Text;      //所选资产分类名称
                foreach (TreeViewNode node1 in treeAssetType.Nodes)
                {
                    node1.TextColor = Color.Black;
                    if (node1.Nodes.Count > 0)
                    {
                        foreach (TreeViewNode node2 in node1.Nodes)
                        {
                            node2.TextColor = Color.Black;
                            if (node2.Nodes.Count > 0)
                            {
                                foreach (TreeViewNode node3 in node2.Nodes)
                                {
                                    node3.TextColor = Color.Black;
                                }
                            }

                        }
                    }
                }

                //把当前项颜色变化下
                TreeViewNode node = e.Nodes;
                node.TextColor = Color.DodgerBlue;
                Close();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void AssetTypeTree_Load(object sender, EventArgs e)
        {
            Bind();
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        public void Bind()
        {
            try
            {
                treeAssetType.Nodes.Clear();       //数据清除
                List<AssetsType> Data = autofacConfig.assTypeService.GetAll();
                if (Data.Count > 0)
                {
                    foreach (AssetsType Row in Data)
                    {
                        
                        if (Row.TLEVEL == 1)
                        {
                            

                            TreeViewNode Node = new TreeViewNode(Row.NAME, null, "一", Row.TYPEID);
                            TreeViewNode SonNode = getData(2, Data, Row.TYPEID);
                            if (SonNode.Nodes.Count > 0)
                            {
                                foreach (TreeViewNode SonRow in SonNode.Nodes)
                                {
                                    Node.Nodes.Add(SonRow);
                                }
                            }
                            treeAssetType.Nodes.Add(Node);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 添加子级资产分类(总共三级)
        /// </summary>
        /// <param name="Level"></param>
        /// <param name="Data"></param>
        /// <param name="ParentID"></param>
        /// <returns></returns>
        public TreeViewNode getData(Int32 Level, List<AssetsType> Data, String ParentID)
        {
            TreeViewNode TreeData = new TreeViewNode();
            if (Level < MaxLevel)
            {
                foreach (AssetsType Row in Data)
                {
                    if (Row.TLEVEL == Level && Row.PARENTTYPEID == ParentID)
                    {
                        TreeViewNode Node = new TreeViewNode(Row.NAME, null, "二", Row.TYPEID);
                        TreeViewNode SonNode = getData(Level + 1, Data, Row.TYPEID);
                        if (SonNode.Nodes.Count > 0)
                        {
                            foreach (TreeViewNode SonRow in SonNode.Nodes)
                            {
                                Node.Nodes.Add(SonRow);
                            }
                        }
                        TreeData.Nodes.Add(Node);
                    }
                }
            }
            else if (Level == MaxLevel)
            {
                foreach (AssetsType Row in Data)
                {
                    if (Row.TLEVEL == Level && Row.PARENTTYPEID == ParentID)
                    {
                        TreeViewNode Node = new TreeViewNode(Row.NAME, null, "三", Row.TYPEID);
                        TreeData.Nodes.Add(Node);
                    }
                }
            }
            return TreeData;
        }
    }
}