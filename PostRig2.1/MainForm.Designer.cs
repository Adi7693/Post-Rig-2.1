namespace PostRig2._1
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.HomeRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.HomeRibbonNewGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.NewProjectButton = new DevExpress.XtraBars.BarButtonItem();
            this.OpenSaveHomePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.OpenProjectButton = new DevExpress.XtraBars.BarButtonItem();
            this.SaveProjectButton = new DevExpress.XtraBars.BarButtonItem();
            this.SaveAsProjectButton = new DevExpress.XtraBars.BarButtonItem();
            this.ReadMeHomePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.HelpFileButton = new DevExpress.XtraBars.BarButtonItem();
            this.CaseStudyButton = new DevExpress.XtraBars.BarButtonItem();
            this.AboutHomePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.AboutHomeButton = new DevExpress.XtraBars.BarButtonItem();
            this.CloseHomePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.CloseProjectButton = new DevExpress.XtraBars.BarButtonItem();
            this.MainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.DamperBarListItem = new DevExpress.XtraBars.BarListItem();
            this.SpringBarlistItem = new DevExpress.XtraBars.BarListItem();
            this.BodyBarListItem = new DevExpress.XtraBars.BarListItem();
            this.DesignRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.BodyDesignPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.SuspDesignPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PropertiesTreeList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.DesignTreelist = new DevExpress.XtraTreeList.TreeList();
            this.DesignTreelistColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.barCheckItem2 = new DevExpress.XtraBars.BarCheckItem();
            this.SpringCheckItem = new DevExpress.XtraBars.BarCheckItem();
            this.DamperCheckItem = new DevExpress.XtraBars.BarCheckItem();
            ((System.ComponentModel.ISupportInitialize)(this.MainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesignTreelist)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeRibbonPage
            // 
            this.HomeRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.HomeRibbonNewGroup,
            this.OpenSaveHomePageGroup,
            this.ReadMeHomePageGroup,
            this.AboutHomePageGroup,
            this.CloseHomePageGroup});
            this.HomeRibbonPage.Name = "HomeRibbonPage";
            this.HomeRibbonPage.Text = "Home";
            // 
            // HomeRibbonNewGroup
            // 
            this.HomeRibbonNewGroup.ItemLinks.Add(this.NewProjectButton);
            this.HomeRibbonNewGroup.Name = "HomeRibbonNewGroup";
            this.HomeRibbonNewGroup.Text = "New";
            // 
            // NewProjectButton
            // 
            this.NewProjectButton.Caption = "New Project";
            this.NewProjectButton.Id = 17;
            this.NewProjectButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("NewProjectButton.ImageOptions.Image")));
            this.NewProjectButton.Name = "NewProjectButton";
            this.NewProjectButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // OpenSaveHomePageGroup
            // 
            this.OpenSaveHomePageGroup.ItemLinks.Add(this.OpenProjectButton);
            this.OpenSaveHomePageGroup.ItemLinks.Add(this.SaveProjectButton);
            this.OpenSaveHomePageGroup.ItemLinks.Add(this.SaveAsProjectButton);
            this.OpenSaveHomePageGroup.Name = "OpenSaveHomePageGroup";
            this.OpenSaveHomePageGroup.Text = "Open/Save";
            // 
            // OpenProjectButton
            // 
            this.OpenProjectButton.Caption = "Open";
            this.OpenProjectButton.Id = 18;
            this.OpenProjectButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("OpenProjectButton.ImageOptions.Image")));
            this.OpenProjectButton.Name = "OpenProjectButton";
            this.OpenProjectButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // SaveProjectButton
            // 
            this.SaveProjectButton.Caption = "Save";
            this.SaveProjectButton.Id = 19;
            this.SaveProjectButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SaveProjectButton.ImageOptions.Image")));
            this.SaveProjectButton.Name = "SaveProjectButton";
            this.SaveProjectButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // SaveAsProjectButton
            // 
            this.SaveAsProjectButton.Caption = "SaveAs";
            this.SaveAsProjectButton.Id = 20;
            this.SaveAsProjectButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsProjectButton.ImageOptions.Image")));
            this.SaveAsProjectButton.Name = "SaveAsProjectButton";
            this.SaveAsProjectButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // ReadMeHomePageGroup
            // 
            this.ReadMeHomePageGroup.ItemLinks.Add(this.HelpFileButton);
            this.ReadMeHomePageGroup.ItemLinks.Add(this.CaseStudyButton);
            this.ReadMeHomePageGroup.Name = "ReadMeHomePageGroup";
            this.ReadMeHomePageGroup.Text = "Read Me";
            // 
            // HelpFileButton
            // 
            this.HelpFileButton.Caption = "Help";
            this.HelpFileButton.Id = 21;
            this.HelpFileButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HelpFileButton.ImageOptions.Image")));
            this.HelpFileButton.Name = "HelpFileButton";
            this.HelpFileButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // CaseStudyButton
            // 
            this.CaseStudyButton.Caption = "Case Study";
            this.CaseStudyButton.Id = 22;
            this.CaseStudyButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CaseStudyButton.ImageOptions.Image")));
            this.CaseStudyButton.Name = "CaseStudyButton";
            this.CaseStudyButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // AboutHomePageGroup
            // 
            this.AboutHomePageGroup.ItemLinks.Add(this.AboutHomeButton);
            this.AboutHomePageGroup.Name = "AboutHomePageGroup";
            this.AboutHomePageGroup.Text = "About";
            // 
            // AboutHomeButton
            // 
            this.AboutHomeButton.Caption = "About";
            this.AboutHomeButton.Id = 23;
            this.AboutHomeButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AboutHomeButton.ImageOptions.Image")));
            this.AboutHomeButton.Name = "AboutHomeButton";
            this.AboutHomeButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // CloseHomePageGroup
            // 
            this.CloseHomePageGroup.ItemLinks.Add(this.CloseProjectButton);
            this.CloseHomePageGroup.Name = "CloseHomePageGroup";
            this.CloseHomePageGroup.Text = "Close";
            // 
            // CloseProjectButton
            // 
            this.CloseProjectButton.Caption = "Close";
            this.CloseProjectButton.Id = 24;
            this.CloseProjectButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CloseProjectButton.ImageOptions.Image")));
            this.CloseProjectButton.Name = "CloseProjectButton";
            this.CloseProjectButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // MainRibbonControl
            // 
            this.MainRibbonControl.ExpandCollapseItem.Id = 0;
            this.MainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MainRibbonControl.ExpandCollapseItem,
            this.NewProjectButton,
            this.OpenProjectButton,
            this.SaveProjectButton,
            this.SaveAsProjectButton,
            this.HelpFileButton,
            this.CaseStudyButton,
            this.AboutHomeButton,
            this.CloseProjectButton,
            this.DamperBarListItem,
            this.SpringBarlistItem,
            this.BodyBarListItem});
            this.MainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.MainRibbonControl.MaxItemId = 31;
            this.MainRibbonControl.Name = "MainRibbonControl";
            this.MainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.HomeRibbonPage,
            this.DesignRibbonPage});
            this.MainRibbonControl.Size = new System.Drawing.Size(1248, 143);
            // 
            // DamperBarListItem
            // 
            this.DamperBarListItem.Caption = "Damper";
            this.DamperBarListItem.Id = 28;
            this.DamperBarListItem.Name = "DamperBarListItem";
            this.DamperBarListItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.DamperBarListItem.Strings.AddRange(new object[] {
            "New",
            "Import",
            "Export"});
            // 
            // SpringBarlistItem
            // 
            this.SpringBarlistItem.Caption = "Spring";
            this.SpringBarlistItem.Id = 29;
            this.SpringBarlistItem.Name = "SpringBarlistItem";
            this.SpringBarlistItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.SpringBarlistItem.Strings.AddRange(new object[] {
            "New",
            "Import",
            "Export"});
            // 
            // BodyBarListItem
            // 
            this.BodyBarListItem.Caption = "Body";
            this.BodyBarListItem.Id = 30;
            this.BodyBarListItem.Name = "BodyBarListItem";
            this.BodyBarListItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.BodyBarListItem.Strings.AddRange(new object[] {
            "New",
            "Import",
            "Export"});
            this.BodyBarListItem.ListItemClick += new DevExpress.XtraBars.ListItemClickEventHandler(this.BodyBarListItem_ListItemClick);
            // 
            // DesignRibbonPage
            // 
            this.DesignRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.BodyDesignPageGroup,
            this.SuspDesignPageGroup});
            this.DesignRibbonPage.Name = "DesignRibbonPage";
            this.DesignRibbonPage.Text = "Design";
            // 
            // BodyDesignPageGroup
            // 
            this.BodyDesignPageGroup.ItemLinks.Add(this.BodyBarListItem);
            this.BodyDesignPageGroup.Name = "BodyDesignPageGroup";
            this.BodyDesignPageGroup.Text = "Body";
            // 
            // SuspDesignPageGroup
            // 
            this.SuspDesignPageGroup.ItemLinks.Add(this.SpringBarlistItem);
            this.SuspDesignPageGroup.ItemLinks.Add(this.DamperBarListItem);
            this.SuspDesignPageGroup.Name = "SuspDesignPageGroup";
            this.SuspDesignPageGroup.Text = "Suspension";
            // 
            // PropertiesTreeList
            // 
            this.PropertiesTreeList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.PropertiesTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.PropertiesTreeList.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.PropertiesTreeList.Dock = System.Windows.Forms.DockStyle.Left;
            this.PropertiesTreeList.Location = new System.Drawing.Point(0, 143);
            this.PropertiesTreeList.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.PropertiesTreeList.Name = "PropertiesTreeList";
            this.PropertiesTreeList.BeginUnboundLoad();
            this.PropertiesTreeList.AppendNode(new object[] {
            "Post Rig Project"}, -1);
            this.PropertiesTreeList.AppendNode(new object[] {
            "Components Library"}, 0);
            this.PropertiesTreeList.AppendNode(new object[] {
            "Body"}, 1);
            this.PropertiesTreeList.AppendNode(new object[] {
            "Spring"}, 1);
            this.PropertiesTreeList.AppendNode(new object[] {
            "Damper"}, 1);
            this.PropertiesTreeList.AppendNode(new object[] {
            "CoilOver"}, 1);
            this.PropertiesTreeList.AppendNode(new object[] {
            "Setup"}, 0);
            this.PropertiesTreeList.EndUnboundLoad();
            this.PropertiesTreeList.OptionsView.AutoWidth = false;
            this.PropertiesTreeList.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.RowFocus;
            this.PropertiesTreeList.Size = new System.Drawing.Size(400, 739);
            this.PropertiesTreeList.TabIndex = 2;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 175;
            // 
            // DesignTreelist
            // 
            this.DesignTreelist.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.DesignTreelistColumn});
            this.DesignTreelist.Cursor = System.Windows.Forms.Cursors.Default;
            this.DesignTreelist.Dock = System.Windows.Forms.DockStyle.Left;
            this.DesignTreelist.Location = new System.Drawing.Point(400, 143);
            this.DesignTreelist.Name = "DesignTreelist";
            this.DesignTreelist.BeginUnboundLoad();
            this.DesignTreelist.AppendNode(new object[] {
            "Post Rig Project"}, -1);
            this.DesignTreelist.AppendNode(new object[] {
            "Compnents Library"}, 0);
            this.DesignTreelist.AppendNode(new object[] {
            "Body"}, 1);
            this.DesignTreelist.AppendNode(new object[] {
            "Spring"}, 1);
            this.DesignTreelist.AppendNode(new object[] {
            "Damper"}, 1);
            this.DesignTreelist.AppendNode(new object[] {
            "Coilover"}, 1);
            this.DesignTreelist.AppendNode(new object[] {
            "Setup"}, 0);
            this.DesignTreelist.EndUnboundLoad();
            this.DesignTreelist.OptionsView.AutoWidth = false;
            this.DesignTreelist.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.RowFocus;
            this.DesignTreelist.OptionsView.ShowButtons = false;
            this.DesignTreelist.OptionsView.ShowHorzLines = false;
            this.DesignTreelist.OptionsView.ShowIndicator = false;
            this.DesignTreelist.OptionsView.ShowVertLines = false;
            this.DesignTreelist.Size = new System.Drawing.Size(400, 739);
            this.DesignTreelist.TabIndex = 3;
            // 
            // DesignTreelistColumn
            // 
            this.DesignTreelistColumn.Caption = "Design Treelist";
            this.DesignTreelistColumn.FieldName = "Design Treelist";
            this.DesignTreelistColumn.Name = "DesignTreelistColumn";
            this.DesignTreelistColumn.OptionsColumn.AllowEdit = false;
            this.DesignTreelistColumn.OptionsColumn.AllowFocus = false;
            this.DesignTreelistColumn.OptionsColumn.AllowMove = false;
            this.DesignTreelistColumn.OptionsColumn.AllowSize = false;
            this.DesignTreelistColumn.OptionsColumn.FixedWidth = true;
            this.DesignTreelistColumn.OptionsColumn.ReadOnly = true;
            this.DesignTreelistColumn.Visible = true;
            this.DesignTreelistColumn.VisibleIndex = 0;
            this.DesignTreelistColumn.Width = 234;
            // 
            // barCheckItem2
            // 
            this.barCheckItem2.Caption = "Library";
            this.barCheckItem2.Id = 3;
            this.barCheckItem2.Name = "barCheckItem2";
            // 
            // SpringCheckItem
            // 
            this.SpringCheckItem.Caption = "Spring";
            this.SpringCheckItem.Id = 5;
            this.SpringCheckItem.Name = "SpringCheckItem";
            // 
            // DamperCheckItem
            // 
            this.DamperCheckItem.Caption = "Damper";
            this.DamperCheckItem.Id = 6;
            this.DamperCheckItem.Name = "DamperCheckItem";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 882);
            this.Controls.Add(this.DesignTreelist);
            this.Controls.Add(this.PropertiesTreeList);
            this.Controls.Add(this.MainRibbonControl);
            this.Name = "Mainform";
            this.Ribbon = this.MainRibbonControl;
            this.Text = "Post Rig v2.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.MainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesignTreelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage HomeRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup HomeRibbonNewGroup;
        private DevExpress.XtraBars.Ribbon.RibbonControl MainRibbonControl;
        private DevExpress.XtraTreeList.TreeList PropertiesTreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.TreeList DesignTreelist;
        private DevExpress.XtraTreeList.Columns.TreeListColumn DesignTreelistColumn;
        private DevExpress.XtraBars.BarCheckItem barCheckItem2;
        private DevExpress.XtraBars.BarCheckItem SpringCheckItem;
        private DevExpress.XtraBars.BarCheckItem DamperCheckItem;
        private DevExpress.XtraBars.BarButtonItem NewProjectButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup OpenSaveHomePageGroup;
        private DevExpress.XtraBars.BarButtonItem OpenProjectButton;
        private DevExpress.XtraBars.BarButtonItem SaveProjectButton;
        private DevExpress.XtraBars.BarButtonItem SaveAsProjectButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ReadMeHomePageGroup;
        private DevExpress.XtraBars.BarButtonItem HelpFileButton;
        private DevExpress.XtraBars.BarButtonItem CaseStudyButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup AboutHomePageGroup;
        private DevExpress.XtraBars.BarButtonItem AboutHomeButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup CloseHomePageGroup;
        private DevExpress.XtraBars.BarButtonItem CloseProjectButton;
        private DevExpress.XtraBars.BarListItem DamperBarListItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage DesignRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup BodyDesignPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup SuspDesignPageGroup;
        private DevExpress.XtraBars.BarListItem SpringBarlistItem;
        private DevExpress.XtraBars.BarListItem BodyBarListItem;
    }
}

