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

        private Project CurrentProject { get; set; } = new Project();

        public Mainform()
        {
            InitializeComponent();
            DesignTreelist.ExpandAll();
        }

        /*Check why this code does not work. It does not display the name as defined but just "Mainform".*/
        
        private string GiveName()
        {
            string name = string.Empty;

            if (BodyNeedsToAdd)
            {
                name = "Body " + DesignTreelist.Nodes[0].Nodes[0].Nodes[0].Nodes.Count.ToString();
            }

            else if (SpringNeedsToAdd)
            {
                name = "Spring " + DesignTreelist.Nodes[0].Nodes[0].Nodes[1].Nodes.Count.ToString();
            }

            else if (DamperNeedsToAdd)
            {
                name = "Damper " + DesignTreelist.Nodes[0].Nodes[0].Nodes[2].Nodes.Count.ToString();
            }

            
            return name;
        }
        

        private void CreateTemplate()
        {

        }

        private void AddToTreeList(IVehicleComponent vehicleComponent)
        {
            DesignTreelist.BeginUnboundLoad();

            TreeListNode ParentNodeForRoot = null;

            if (BodyNeedsToAdd)
            {
                ParentNodeForRoot = DesignTreelist.Nodes[0].Nodes[0].Nodes[0];
            }
            else if (SpringNeedsToAdd)
            {
                ParentNodeForRoot = DesignTreelist.Nodes[0].Nodes[0].Nodes[1];
            }
            else if (DamperNeedsToAdd)
            {
                ParentNodeForRoot = DesignTreelist.Nodes[0].Nodes[0].Nodes[2];
            }

            TreeListNode NewBody = DesignTreelist.AppendNode(new object[] { null }, ParentNodeForRoot, vehicleComponent);

            

            ParentNodeForRoot.LastNode.SetValue(DesignTreelistColumn, vehicleComponent.Name);

            DesignTreelist.EndUnboundLoad();

            DesignTreelist.ExpandAll();

            BodyNeedsToAdd = false;
            SpringNeedsToAdd = false;
            DamperNeedsToAdd = false;
        }

        private void NewBody()
        {
            IVehicleComponent Body = new VehicleBody(CurrentProject.GetValidName(VehicleComponentType.Body));

            BodyNeedsToAdd = true;
            CurrentProject.BodyNeedsToAdd = true;

            AddToTreeList(Body);

            CurrentProject.AddBody(Body);
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
            IVehicleComponent Spring = new Spring(CurrentProject.GetValidName(VehicleComponentType.Spring));

            SpringNeedsToAdd = true;
            CurrentProject.SpringNeedsToAdd = true;

            AddToTreeList(Spring);

            CurrentProject.AddSpring(Spring);
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
                    ExportSpring();
                    break;

            }

        }

        private void NewDamper()
        {
            IVehicleComponent Damper = new Damper(CurrentProject.GetValidName(VehicleComponentType.Damper));

            DamperNeedsToAdd = true;
            CurrentProject.DamperNeedsToAdd = true;

            AddToTreeList(Damper);

            CurrentProject.AddDamper(Damper);
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

        private DialogResult AskForSave()
        {
            string SaveStr = "Do you want to save the current project?";

            return MessageBox.Show(SaveStr, "Post Rig 2.1", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

        }

        private void NewProjectButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CurrentProject != null)
            {
                DialogResult res = AskForSave();

                if (res == DialogResult.Yes)
                {
                    CurrentProject.Save();
                }
            }
        }

        private void TreeListNode_DoubleClick(object sender, EventArgs e)
        {
            TreeList tree = sender as TreeList;
            TreeListHitInfo hi = tree.CalcHitInfo(tree.PointToClient(Control.MousePosition));
            if (hi.Node != null && hi.Node.Tag != null)
            {
                
            }
        }
    }
}
