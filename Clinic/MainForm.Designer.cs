namespace Clinic
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bBackup = new DevExpress.XtraBars.BarButtonItem();
            this.bRestore = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.bSettings = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.spl = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nApp = new DevExpress.XtraNavBar.NavBarItem();
            this.nPatient = new DevExpress.XtraNavBar.NavBarItem();
            this.nOverall = new DevExpress.XtraNavBar.NavBarItem();
            this.nDoctor = new DevExpress.XtraNavBar.NavBarItem();
            this.dlaf = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spl)).BeginInit();
            this.spl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bBackup,
            this.bRestore,
            this.skinRibbonGalleryBarItem1,
            this.bSettings});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.bSettings);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(808, 143);
            // 
            // bBackup
            // 
            this.bBackup.Caption = "Backup";
            this.bBackup.Glyph = ((System.Drawing.Image)(resources.GetObject("bBackup.Glyph")));
            this.bBackup.Id = 1;
            this.bBackup.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bBackup.LargeGlyph")));
            this.bBackup.Name = "bBackup";
            this.bBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBackup_ItemClick);
            // 
            // bRestore
            // 
            this.bRestore.Caption = "Restore";
            this.bRestore.Glyph = ((System.Drawing.Image)(resources.GetObject("bRestore.Glyph")));
            this.bRestore.Id = 2;
            this.bRestore.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bRestore.LargeGlyph")));
            this.bRestore.Name = "bRestore";
            this.bRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bRestore_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 3;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // bSettings
            // 
            this.bSettings.Caption = "&Settings";
            this.bSettings.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bSettings.Glyph = ((System.Drawing.Image)(resources.GetObject("bSettings.Glyph")));
            this.bSettings.Id = 4;
            this.bSettings.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bSettings.LargeGlyph")));
            this.bSettings.Name = "bSettings";
            this.bSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bSettings_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.MergeOrder = 1;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Settings";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bBackup);
            this.ribbonPageGroup1.ItemLinks.Add(this.bRestore);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Database";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Theme";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bSettings);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Settings";
            // 
            // spl
            // 
            this.spl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spl.Location = new System.Drawing.Point(0, 143);
            this.spl.Name = "spl";
            this.spl.Panel1.Controls.Add(this.navBarControl1);
            this.spl.Panel1.Text = "Panel1";
            this.spl.Panel2.Text = "Panel2";
            this.spl.Size = new System.Drawing.Size(808, 378);
            this.spl.SplitterPosition = 214;
            this.spl.TabIndex = 2;
            this.spl.Text = "splitContainerControl1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nApp,
            this.nPatient,
            this.nOverall,
            this.nDoctor});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 214;
            this.navBarControl1.OptionsNavPane.ShowOverflowButton = false;
            this.navBarControl1.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(214, 378);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Navigation";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nApp),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nPatient),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nOverall),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nDoctor)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nApp
            // 
            this.nApp.Caption = "Appointment";
            this.nApp.LargeImage = ((System.Drawing.Image)(resources.GetObject("nApp.LargeImage")));
            this.nApp.Name = "nApp";
            this.nApp.SmallImage = ((System.Drawing.Image)(resources.GetObject("nApp.SmallImage")));
            this.nApp.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nApp_LinkClicked);
            // 
            // nPatient
            // 
            this.nPatient.Caption = "Patients";
            this.nPatient.LargeImage = ((System.Drawing.Image)(resources.GetObject("nPatient.LargeImage")));
            this.nPatient.Name = "nPatient";
            this.nPatient.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nPatient_LinkClicked);
            // 
            // nOverall
            // 
            this.nOverall.Caption = "Overall View";
            this.nOverall.LargeImage = ((System.Drawing.Image)(resources.GetObject("nOverall.LargeImage")));
            this.nOverall.Name = "nOverall";
            this.nOverall.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nOverall_LinkClicked);
            // 
            // nDoctor
            // 
            this.nDoctor.Caption = "Doctors";
            this.nDoctor.LargeImage = global::Clinic.Properties.Resources.doctor_32x32;
            this.nDoctor.Name = "nDoctor";
            this.nDoctor.SmallImage = global::Clinic.Properties.Resources.doctor_16x16;
            this.nDoctor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nDoctor_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 521);
            this.Controls.Add(this.spl);
            this.Controls.Add(this.ribbon);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spl)).EndInit();
            this.spl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraEditors.SplitContainerControl spl;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nApp;
        private DevExpress.XtraNavBar.NavBarItem nPatient;
        private DevExpress.XtraNavBar.NavBarItem nOverall;
        private DevExpress.XtraBars.BarButtonItem bBackup;
        private DevExpress.XtraBars.BarButtonItem bRestore;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraNavBar.NavBarItem nDoctor;
        private DevExpress.LookAndFeel.DefaultLookAndFeel dlaf;
        private DevExpress.XtraBars.BarButtonItem bSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}