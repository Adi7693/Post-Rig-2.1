using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace PostRig2._1
{
    public partial class Mainform : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private bool CompLibraryNeedsToAdd = false;
        private bool BodyNeedsToAdd = false;
        private bool SpringNeedsToAdd = false;

        public Mainform()
        {
            InitializeComponent();
            DesignTreelist.ExpandAll();
        }

       
        private void AddToTreeList(TreeList treeList)
        {
            if (CompLibraryNeedsToAdd)
            {
                treeList.BeginUnboundLoad();

                TreeListNode ParentNodeForRoot = PropertiesTreeList.Nodes[0];
                TreeListNode NewProject = treeList.AppendNode(new object[] { "New Component Library" }, ParentNodeForRoot);

                treeList.EndUnboundLoad();

                CompLibraryNeedsToAdd = false;
            }

            if (BodyNeedsToAdd)
            {
                treeList.BeginUnboundLoad();

                TreeListNode ParentNodeForRoot = PropertiesTreeList.Nodes[0].Nodes[0].Nodes[0];
                TreeListNode NewProject = treeList.AppendNode(new object[] { "New Body" }, ParentNodeForRoot);

                treeList.EndUnboundLoad();

                BodyNeedsToAdd = false;
            }

            if(SpringNeedsToAdd)
            {
                treeList.BeginUnboundLoad();

                TreeListNode ParentNodeForRoot = PropertiesTreeList.Nodes[0].Nodes[0].Nodes[1];
                TreeListNode NewProject = treeList.AppendNode(new object[] { "New Spring" }, ParentNodeForRoot);

                treeList.EndUnboundLoad();

                SpringNeedsToAdd = false;
            }


            PropertiesTreeList.ExpandAll();
        }

        private void CompLibraryButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CompLibraryNeedsToAdd = true;

            AddToTreeList(PropertiesTreeList);
        }

        private void BodyButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BodyNeedsToAdd = true;

            AddToTreeList(PropertiesTreeList);
        }

        private void AddNewSpringButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SpringNeedsToAdd = true;

            AddToTreeList(PropertiesTreeList);
        }

        private void BodyBarListItem_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {
            BodyNeedsToAdd = true;

            AddToTreeList(PropertiesTreeList);


            MessageBox.Show("Blah is clicked", "Note", MessageBoxButtons.OK);
            
        }

        
    }
}
