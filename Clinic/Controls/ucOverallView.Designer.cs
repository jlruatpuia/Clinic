namespace Clinic.Controls
{
    partial class ucOverallView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucOverallView));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bPrint = new DevExpress.XtraBars.BarSubItem();
            this.bClinicReport = new DevExpress.XtraBars.BarButtonItem();
            this.bCurrentView = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPNM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bExport = new DevExpress.XtraBars.BarSubItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.beiFR = new DevExpress.XtraBars.BarEditItem();
            this.dtpFR = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.beiTO = new DevExpress.XtraBars.BarEditItem();
            this.dtpTO = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.bShow = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFR.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTO.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bPrint,
            this.bClinicReport,
            this.bCurrentView,
            this.bExport,
            this.beiFR,
            this.beiTO,
            this.bShow});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dtpFR,
            this.dtpTO});
            this.ribbonControl1.Size = new System.Drawing.Size(821, 141);
            // 
            // bPrint
            // 
            this.bPrint.Caption = "&Print";
            this.bPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("bPrint.Glyph")));
            this.bPrint.Id = 2;
            this.bPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bPrint.LargeGlyph")));
            this.bPrint.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bClinicReport),
            new DevExpress.XtraBars.LinkPersistInfo(this.bCurrentView)});
            this.bPrint.Name = "bPrint";
            // 
            // bClinicReport
            // 
            this.bClinicReport.Caption = "Patient Report";
            this.bClinicReport.Id = 3;
            this.bClinicReport.Name = "bClinicReport";
            this.bClinicReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bClinicReport_ItemClick);
            // 
            // bCurrentView
            // 
            this.bCurrentView.Caption = "Current View";
            this.bCurrentView.Id = 4;
            this.bCurrentView.Name = "bCurrentView";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Overall View";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bPrint);
            this.ribbonPageGroup1.ItemLinks.Add(this.bExport);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Print & Export";
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 141);
            this.grd.MainView = this.grv;
            this.grd.MenuManager = this.ribbonControl1;
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(821, 361);
            this.grd.TabIndex = 1;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTID,
            this.colTDT,
            this.colPID,
            this.colPNM,
            this.colADR,
            this.colPHN,
            this.colAMT});
            this.grv.GridControl = this.grd;
            this.grv.Name = "grv";
            this.grv.OptionsView.ShowFooter = true;
            this.grv.OptionsView.ShowGroupPanel = false;
            // 
            // colTID
            // 
            this.colTID.Caption = "gridColumn1";
            this.colTID.FieldName = "TreatmentID";
            this.colTID.Name = "colTID";
            this.colTID.OptionsColumn.AllowEdit = false;
            this.colTID.OptionsColumn.AllowFocus = false;
            this.colTID.OptionsColumn.ReadOnly = true;
            // 
            // colTDT
            // 
            this.colTDT.Caption = "Date";
            this.colTDT.FieldName = "TreatmentDate";
            this.colTDT.Name = "colTDT";
            this.colTDT.OptionsColumn.AllowEdit = false;
            this.colTDT.OptionsColumn.AllowFocus = false;
            this.colTDT.OptionsColumn.ReadOnly = true;
            this.colTDT.Visible = true;
            this.colTDT.VisibleIndex = 0;
            this.colTDT.Width = 90;
            // 
            // colPID
            // 
            this.colPID.Caption = "Patient ID";
            this.colPID.FieldName = "PatientID";
            this.colPID.Name = "colPID";
            this.colPID.OptionsColumn.AllowEdit = false;
            this.colPID.OptionsColumn.AllowFocus = false;
            this.colPID.OptionsColumn.ReadOnly = true;
            this.colPID.Visible = true;
            this.colPID.VisibleIndex = 1;
            this.colPID.Width = 115;
            // 
            // colPNM
            // 
            this.colPNM.Caption = "Patient Name";
            this.colPNM.FieldName = "PatientName";
            this.colPNM.Name = "colPNM";
            this.colPNM.OptionsColumn.AllowEdit = false;
            this.colPNM.OptionsColumn.AllowFocus = false;
            this.colPNM.OptionsColumn.ReadOnly = true;
            this.colPNM.Visible = true;
            this.colPNM.VisibleIndex = 2;
            this.colPNM.Width = 165;
            // 
            // colADR
            // 
            this.colADR.Caption = "Address";
            this.colADR.FieldName = "Address";
            this.colADR.Name = "colADR";
            this.colADR.OptionsColumn.AllowEdit = false;
            this.colADR.OptionsColumn.AllowFocus = false;
            this.colADR.OptionsColumn.ReadOnly = true;
            this.colADR.Visible = true;
            this.colADR.VisibleIndex = 3;
            this.colADR.Width = 213;
            // 
            // colPHN
            // 
            this.colPHN.Caption = "Phone No";
            this.colPHN.FieldName = "PhoneNo";
            this.colPHN.Name = "colPHN";
            this.colPHN.OptionsColumn.AllowEdit = false;
            this.colPHN.OptionsColumn.AllowFocus = false;
            this.colPHN.OptionsColumn.ReadOnly = true;
            this.colPHN.Visible = true;
            this.colPHN.VisibleIndex = 4;
            this.colPHN.Width = 122;
            // 
            // colAMT
            // 
            this.colAMT.Caption = "Amount";
            this.colAMT.DisplayFormat.FormatString = "{0:C2}";
            this.colAMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAMT.FieldName = "Amount";
            this.colAMT.Name = "colAMT";
            this.colAMT.OptionsColumn.AllowEdit = false;
            this.colAMT.OptionsColumn.AllowFocus = false;
            this.colAMT.OptionsColumn.ReadOnly = true;
            this.colAMT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0:C2}")});
            this.colAMT.Visible = true;
            this.colAMT.VisibleIndex = 5;
            this.colAMT.Width = 98;
            // 
            // bExport
            // 
            this.bExport.Caption = "E&xport";
            this.bExport.Glyph = ((System.Drawing.Image)(resources.GetObject("bExport.Glyph")));
            this.bExport.Id = 6;
            this.bExport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bExport.LargeGlyph")));
            this.bExport.Name = "bExport";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.beiFR);
            this.ribbonPageGroup2.ItemLinks.Add(this.beiTO);
            this.ribbonPageGroup2.ItemLinks.Add(this.bShow);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "View Selection";
            // 
            // beiFR
            // 
            this.beiFR.Caption = "From:";
            this.beiFR.Edit = this.dtpFR;
            this.beiFR.Id = 7;
            this.beiFR.Name = "beiFR";
            this.beiFR.Width = 100;
            // 
            // dtpFR
            // 
            this.dtpFR.AutoHeight = false;
            this.dtpFR.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFR.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFR.Name = "dtpFR";
            // 
            // beiTO
            // 
            this.beiTO.Caption = "To:    ";
            this.beiTO.Edit = this.dtpTO;
            this.beiTO.Id = 8;
            this.beiTO.Name = "beiTO";
            this.beiTO.Width = 100;
            // 
            // dtpTO
            // 
            this.dtpTO.AutoHeight = false;
            this.dtpTO.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTO.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTO.Name = "dtpTO";
            // 
            // bShow
            // 
            this.bShow.Caption = "&Show";
            this.bShow.Glyph = ((System.Drawing.Image)(resources.GetObject("bShow.Glyph")));
            this.bShow.Id = 9;
            this.bShow.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bShow.LargeGlyph")));
            this.bShow.Name = "bShow";
            this.bShow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bShow_ItemClick);
            // 
            // ucOverallView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grd);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ucOverallView";
            this.Size = new System.Drawing.Size(821, 502);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFR.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTO.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraGrid.Columns.GridColumn colTID;
        private DevExpress.XtraGrid.Columns.GridColumn colTDT;
        private DevExpress.XtraGrid.Columns.GridColumn colPID;
        private DevExpress.XtraGrid.Columns.GridColumn colPNM;
        private DevExpress.XtraGrid.Columns.GridColumn colADR;
        private DevExpress.XtraGrid.Columns.GridColumn colPHN;
        private DevExpress.XtraGrid.Columns.GridColumn colAMT;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarSubItem bPrint;
        private DevExpress.XtraBars.BarButtonItem bClinicReport;
        private DevExpress.XtraBars.BarButtonItem bCurrentView;
        private DevExpress.XtraBars.BarSubItem bExport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarEditItem beiFR;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dtpFR;
        private DevExpress.XtraBars.BarEditItem beiTO;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dtpTO;
        private DevExpress.XtraBars.BarButtonItem bShow;
    }
}
