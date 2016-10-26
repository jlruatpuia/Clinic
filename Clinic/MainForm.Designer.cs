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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.spl = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nApp = new DevExpress.XtraNavBar.NavBarItem();
            this.nPatient = new DevExpress.XtraNavBar.NavBarItem();
            this.nOverall = new DevExpress.XtraNavBar.NavBarItem();
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
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(808, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.MergeOrder = 1;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Settings";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 494);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(808, 31);
            // 
            // spl
            // 
            this.spl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spl.Location = new System.Drawing.Point(0, 143);
            this.spl.Name = "spl";
            this.spl.Panel1.Controls.Add(this.navBarControl1);
            this.spl.Panel1.Text = "Panel1";
            this.spl.Panel2.Text = "Panel2";
            this.spl.Size = new System.Drawing.Size(808, 351);
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
            this.nOverall});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 214;
            this.navBarControl1.OptionsNavPane.ShowOverflowButton = false;
            this.navBarControl1.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(214, 351);
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
            new DevExpress.XtraNavBar.NavBarItemLink(this.nOverall)});
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 525);
            this.Controls.Add(this.spl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
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
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.SplitContainerControl spl;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nApp;
        private DevExpress.XtraNavBar.NavBarItem nPatient;
        private DevExpress.XtraNavBar.NavBarItem nOverall;
    }
}