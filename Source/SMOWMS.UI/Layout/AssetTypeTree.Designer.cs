using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class AssetTypeTree : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.treeAssetType = new Smobiler.Core.Controls.TreeView();
            // 
            // treeAssetType
            // 
            this.treeAssetType.Name = "treeAssetType";
            this.treeAssetType.Size = new System.Drawing.Size(250, 300);
            this.treeAssetType.NodePress += new Smobiler.Core.Controls.TreeViewNodeClickEventHandler(this.treeAssetType_NodePress);
            // 
            // AssetTypeTree
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.treeAssetType});
            this.Size = new System.Drawing.Size(250, 300);
            this.Load += new System.EventHandler(this.AssetTypeTree_Load);
            this.Name = "AssetTypeTree";

        }
        #endregion

        private Smobiler.Core.Controls.TreeView treeAssetType;
    }
}