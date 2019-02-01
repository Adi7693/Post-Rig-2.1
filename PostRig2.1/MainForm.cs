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
using ComponentLibrary;

namespace PostRig2._1
{
    public partial class Mainform : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private bool BodyNeedsToAdd = false;
        private bool SpringNeedsToAdd = false;
        private bool DamperNeedsToAdd = false;


        Project project = new Project();

        public Mainform()
        {
            InitializeComponent();
            DesignTreelist.ExpandAll();
        }

        /* Check why this code does not work. It does not display the name as defined but just "Mainform".
        
        private string GiveName(TreeList treeList)
        {
            if (BodyNeedsToAdd)
            {
                string Name = "Body " + treeList.Nodes[0].Nodes[0].Nodes[0].Nodes.Count.ToString();
            }

            else if (SpringNeedsToAdd)
            {
                string Name = "Spring " + treeList.Nodes[0].Nodes[0].Nodes[1].Nodes.Count.ToString();
            }

            else if (DamperNeedsToAdd)
            {
                string Name = "Damper " + treeList.Nodes[0].Nodes[0].Nodes[2].Nodes.Count.ToString();
            }

            return Name;
        }
        */

        private string BodyName(TreeList treeList)
        {
            string bodyName = "Body " + treeList.Nodes[0].Nodes[0].Nodes[0].Nodes.Count.ToString();

            return bodyName;
        }

        private string SpringName (TreeList treeList)
        {
            string springName = "Spring " + treeList.Nodes[0].Nodes[0].Nodes[1].Nodes.Count.ToString();

            return springName;
        }

        private string DamperName (TreeList treeList)
        {
            string damperName = "Damper " + treeList.Nodes[0].Nodes[0].Nodes[2].Nodes.Count.ToString();

            return damperName;
        }

        private void AddToTreeList(TreeList treeList)
        {
            if (BodyNeedsToAdd)
            {
                treeList.BeginUnboundLoad();

                TreeListNode ParentNodeForRoot = DesignTreelist.Nodes[0].Nodes[0].Nodes[0];
                TreeListNode NewBody = treeList.AppendNode(new object[] { null }, ParentNodeForRoot);

                ParentNodeForRoot.LastNode.SetValue(DesignTreelistColumn, BodyName(DesignTreelist));

                treeList.EndUnboundLoad();

                BodyNeedsToAdd = false;
            }

            if(SpringNeedsToAdd)
            {
                treeList.BeginUnboundLoad();

                TreeListNode ParentNodeForRoot = DesignTreelist.Nodes[0].Nodes[0].Nodes[1];
                TreeListNode NewSpring = treeList.AppendNode(new object[] { null }, ParentNodeForRoot);

                ParentNodeForRoot.LastNode.SetValue(DesignTreelistColumn, SpringName(DesignTreelist));

                treeList.EndUnboundLoad();

                SpringNeedsToAdd = false;
            }

            if (DamperNeedsToAdd)
            {
                treeList.BeginUnboundLoad();

                TreeListNode ParentNodeForRoot = DesignTreelist.Nodes[0].Nodes[0].Nodes[2];
                TreeListNode NewDamper = treeList.AppendNode(new object[] { null }, ParentNodeForRoot);

                ParentNodeForRoot.LastNode.SetValue(DesignTreelistColumn, DamperName(DesignTreelist));

                treeList.EndUnboundLoad();

                DamperNeedsToAdd = false;
            }

            DesignTreelist.ExpandAll();
        }

        private void NewBody()
        {
            BodyNeedsToAdd = true;
            project.BodyNeedsToAdd = true;

            AddToTreeList(DesignTreelist);

            string Body = DesignTreelist.Nodes[0].Nodes[0].Nodes[0].LastNode.GetValue(DesignTreelistColumn).ToString();

            project.AddBody(Body);
        }

        private void ImportBody()
        {

        }

        private void ExportBody()
        {

        }

        private void BodyBarListItem_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    NewBody();
                    break;
                case 1:
                    ImportBody();
                    break;
                case 2:
                    ExportBody();
                    break;
            }
        }

        private void NewSpring()
        {
            SpringNeedsToAdd = true;
            project.SpringNeedsToAdd = true;

            AddToTreeList(DesignTreelist);

            string Spring = DesignTreelist.Nodes[0].Nodes[0].Nodes[1].LastNode.GetValue(DesignTreelistColumn).ToString();

            project.AddSpring(Spring);
        }

        private void ImportSpring()
        {

        }

        private void ExportSpring()
        {

        }

        private void SpringBarlistItem_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    NewSpring();
                    break;
                case 1:
                    ImportSpring();
                    break;
                case 2:
                    ImportDamper();
                    break;

            }

        }

        private void NewDamper()
        {
            DamperNeedsToAdd = true;
            project.DamperNeedsToAdd = true;

            AddToTreeList(DesignTreelist);

            string Damper = DesignTreelist.Nodes[0].Nodes[0].Nodes[2].LastNode.GetValue(DesignTreelistColumn).ToString();

            project.AddDamper(Damper);
        }

        private void ImportDamper()
        {

        }

        private void ExportDamper()
        {

        }

        private void DamperBarListItem_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    NewDamper();
                    break;
                case 1:
                    ImportDamper();
                    break;
                case 2:
                    ExportDamper();
                    break;
            }
        }
    }
}
