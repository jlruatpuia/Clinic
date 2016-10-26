namespace Clinic
{
    partial class rptClinicReport
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.bcdMAIN = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.lbSEX = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.lbTDT = new DevExpress.XtraReports.UI.XRLabel();
            this.lbAGE = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbADR = new DevExpress.XtraReports.UI.XRLabel();
            this.lbPNM = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbPID = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCMP = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbEXM = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTMP = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbMED = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10,
            this.lbCMP,
            this.xrLabel13,
            this.lbEXM,
            this.xrLabel15,
            this.lbTMP,
            this.xrLabel17,
            this.lbMED});
            this.Detail.HeightF = 100F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 50F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 50F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.bcdMAIN,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.ReportHeader.HeightF = 137.5F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // bcdMAIN
            // 
            this.bcdMAIN.AutoModule = true;
            this.bcdMAIN.LocationFloat = new DevExpress.Utils.PointFloat(383F, 0F);
            this.bcdMAIN.Name = "bcdMAIN";
            this.bcdMAIN.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.bcdMAIN.ShowText = false;
            this.bcdMAIN.SizeF = new System.Drawing.SizeF(100F, 92F);
            this.bcdMAIN.StylePriority.UsePadding = false;
            this.bcdMAIN.StylePriority.UseTextAlignment = false;
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.bcdMAIN.Symbology = qrCodeGenerator1;
            this.bcdMAIN.Text = "ST MART";
            this.bcdMAIN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(101.0417F, 105F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(281.9584F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "CLINIC REPORT";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(101.0417F, 76F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(281.9583F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Phone: 8731068220, 9856904500";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(101.0417F, 23F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(281.9583F, 53F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Ramhlun Venglai\r\nOpposite Biakliana Petrol Pump,\r\nAizawl Mizoram 796001";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(101.0417F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(281.9583F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "HOPE DENTAL CLINIC";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2,
            this.lbSEX,
            this.xrLabel7,
            this.xrLine1,
            this.lbTDT,
            this.lbAGE,
            this.xrLabel12,
            this.lbADR,
            this.lbPNM,
            this.xrLabel9,
            this.xrLabel8,
            this.lbPID,
            this.xrLabel6,
            this.xrLabel5});
            this.PageHeader.HeightF = 107F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 22.99999F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(483F, 2F);
            // 
            // lbSEX
            // 
            this.lbSEX.LocationFloat = new DevExpress.Utils.PointFloat(383F, 47.99998F);
            this.lbSEX.Name = "lbSEX";
            this.lbSEX.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbSEX.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbSEX.Text = "lbSEX";
            // 
            // xrLabel7
            // 
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(328.1249F, 47.99998F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(54.87524F, 23F);
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Sex:";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 93.99998F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(483F, 13F);
            // 
            // lbTDT
            // 
            this.lbTDT.LocationFloat = new DevExpress.Utils.PointFloat(383F, 0F);
            this.lbTDT.Name = "lbTDT";
            this.lbTDT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTDT.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbTDT.StylePriority.UseTextAlignment = false;
            this.lbTDT.Text = "lbTDT";
            this.lbTDT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbAGE
            // 
            this.lbAGE.LocationFloat = new DevExpress.Utils.PointFloat(383F, 24.99999F);
            this.lbAGE.Name = "lbAGE";
            this.lbAGE.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbAGE.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbAGE.StylePriority.UseTextAlignment = false;
            this.lbAGE.Text = "lbAGE";
            this.lbAGE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(328.1249F, 24.99999F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(54.87506F, 23F);
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Age:";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbADR
            // 
            this.lbADR.LocationFloat = new DevExpress.Utils.PointFloat(68.99999F, 70.99998F);
            this.lbADR.Name = "lbADR";
            this.lbADR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbADR.SizeF = new System.Drawing.SizeF(259.1249F, 23F);
            this.lbADR.StylePriority.UseTextAlignment = false;
            this.lbADR.Text = "lbADR";
            this.lbADR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbPNM
            // 
            this.lbPNM.LocationFloat = new DevExpress.Utils.PointFloat(68.99999F, 47.99998F);
            this.lbPNM.Name = "lbPNM";
            this.lbPNM.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbPNM.SizeF = new System.Drawing.SizeF(259.1249F, 23F);
            this.lbPNM.StylePriority.UseTextAlignment = false;
            this.lbPNM.Text = "lbPNM";
            this.lbPNM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 70.99998F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(69F, 23F);
            this.xrLabel9.StylePriority.UsePadding = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Address:";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel8
            // 
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 47.99998F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(69F, 23F);
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Name:";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbPID
            // 
            this.lbPID.LocationFloat = new DevExpress.Utils.PointFloat(68.99999F, 24.99999F);
            this.lbPID.Name = "lbPID";
            this.lbPID.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbPID.SizeF = new System.Drawing.SizeF(259.1249F, 23F);
            this.lbPID.StylePriority.UseTextAlignment = false;
            this.lbPID.Text = "lbPID";
            this.lbPID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 24.99999F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(69F, 23F);
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "ID:";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(328.1249F, 23F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.Text = "Patient Information";
            // 
            // xrLabel10
            // 
            this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(119.625F, 25F);
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UsePadding = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Chief Complain:";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbCMP
            // 
            this.lbCMP.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbCMP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCMP.LocationFloat = new DevExpress.Utils.PointFloat(119.625F, 0F);
            this.lbCMP.Name = "lbCMP";
            this.lbCMP.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCMP.SizeF = new System.Drawing.SizeF(363.375F, 25F);
            this.lbCMP.StylePriority.UseBorders = false;
            this.lbCMP.StylePriority.UseFont = false;
            this.lbCMP.StylePriority.UsePadding = false;
            this.lbCMP.StylePriority.UseTextAlignment = false;
            this.lbCMP.Text = "lbCMP";
            this.lbCMP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(0F, 25F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(119.625F, 25F);
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UsePadding = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "Examination:";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbEXM
            // 
            this.lbEXM.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbEXM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEXM.LocationFloat = new DevExpress.Utils.PointFloat(119.625F, 25F);
            this.lbEXM.Name = "lbEXM";
            this.lbEXM.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbEXM.SizeF = new System.Drawing.SizeF(363.375F, 25F);
            this.lbEXM.StylePriority.UseBorders = false;
            this.lbEXM.StylePriority.UseFont = false;
            this.lbEXM.StylePriority.UsePadding = false;
            this.lbEXM.StylePriority.UseTextAlignment = false;
            this.lbEXM.Text = "lbEXM";
            this.lbEXM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(0F, 50F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(119.625F, 25F);
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UsePadding = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "Treatment Plan:";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbTMP
            // 
            this.lbTMP.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbTMP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTMP.LocationFloat = new DevExpress.Utils.PointFloat(119.625F, 50F);
            this.lbTMP.Name = "lbTMP";
            this.lbTMP.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTMP.SizeF = new System.Drawing.SizeF(363.375F, 25F);
            this.lbTMP.StylePriority.UseBorders = false;
            this.lbTMP.StylePriority.UseFont = false;
            this.lbTMP.StylePriority.UsePadding = false;
            this.lbTMP.StylePriority.UseTextAlignment = false;
            this.lbTMP.Text = "lbTMP";
            this.lbTMP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel17
            // 
            this.xrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(0F, 75F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(119.625F, 25F);
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UsePadding = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Medicine:";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbMED
            // 
            this.lbMED.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbMED.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMED.LocationFloat = new DevExpress.Utils.PointFloat(119.625F, 75F);
            this.lbMED.Multiline = true;
            this.lbMED.Name = "lbMED";
            this.lbMED.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbMED.SizeF = new System.Drawing.SizeF(363.375F, 25F);
            this.lbMED.StylePriority.UseBorders = false;
            this.lbMED.StylePriority.UseFont = false;
            this.lbMED.StylePriority.UsePadding = false;
            this.lbMED.StylePriority.UseTextAlignment = false;
            this.lbMED.Text = "lbMED";
            this.lbMED.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // rptClinicReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader});
            this.DisplayName = "Clinic Report";
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
            this.PageHeight = 827;
            this.PageWidth = 583;
            this.PaperKind = System.Drawing.Printing.PaperKind.A5;
            this.Version = "15.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRBarCode bcdMAIN;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel lbTDT;
        private DevExpress.XtraReports.UI.XRLabel lbAGE;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel lbADR;
        private DevExpress.XtraReports.UI.XRLabel lbPNM;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel lbPID;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRLabel lbSEX;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel lbCMP;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel lbEXM;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel lbTMP;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel lbMED;
    }
}
