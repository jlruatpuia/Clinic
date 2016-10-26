namespace Clinic
{
    partial class frmPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatient));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtpDOB = new DevExpress.XtraEditors.DateEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtCMT = new DevExpress.XtraEditors.MemoEdit();
            this.txtHIS = new DevExpress.XtraEditors.MemoEdit();
            this.txtADR = new DevExpress.XtraEditors.TextEdit();
            this.txtPHN = new DevExpress.XtraEditors.TextEdit();
            this.cboSEX = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPNM = new DevExpress.XtraEditors.TextEdit();
            this.txtPID = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDOB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDOB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHIS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtADR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPHN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSEX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPNM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dtpDOB);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.txtCMT);
            this.layoutControl1.Controls.Add(this.txtHIS);
            this.layoutControl1.Controls.Add(this.txtADR);
            this.layoutControl1.Controls.Add(this.txtPHN);
            this.layoutControl1.Controls.Add(this.cboSEX);
            this.layoutControl1.Controls.Add(this.txtPNM);
            this.layoutControl1.Controls.Add(this.txtPID);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-434, 413, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(465, 255);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtpDOB
            // 
            this.dtpDOB.EditValue = null;
            this.dtpDOB.Location = new System.Drawing.Point(368, 60);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDOB.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDOB.Size = new System.Drawing.Size(85, 20);
            this.dtpDOB.StyleController = this.layoutControl1;
            this.dtpDOB.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(375, 213);
            this.btnCancel.MaximumSize = new System.Drawing.Size(78, 30);
            this.btnCancel.MinimumSize = new System.Drawing.Size(78, 30);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 30);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(283, 213);
            this.btnSave.MaximumSize = new System.Drawing.Size(78, 30);
            this.btnSave.MinimumSize = new System.Drawing.Size(78, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 30);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCMT
            // 
            this.txtCMT.Location = new System.Drawing.Point(91, 150);
            this.txtCMT.Name = "txtCMT";
            this.txtCMT.Size = new System.Drawing.Size(362, 59);
            this.txtCMT.StyleController = this.layoutControl1;
            this.txtCMT.TabIndex = 11;
            // 
            // txtHIS
            // 
            this.txtHIS.Location = new System.Drawing.Point(91, 108);
            this.txtHIS.Name = "txtHIS";
            this.txtHIS.Size = new System.Drawing.Size(362, 38);
            this.txtHIS.StyleController = this.layoutControl1;
            this.txtHIS.TabIndex = 10;
            // 
            // txtADR
            // 
            this.txtADR.Location = new System.Drawing.Point(91, 84);
            this.txtADR.Name = "txtADR";
            this.txtADR.Size = new System.Drawing.Size(362, 20);
            this.txtADR.StyleController = this.layoutControl1;
            this.txtADR.TabIndex = 9;
            // 
            // txtPHN
            // 
            this.txtPHN.Location = new System.Drawing.Point(91, 60);
            this.txtPHN.Name = "txtPHN";
            this.txtPHN.Size = new System.Drawing.Size(194, 20);
            this.txtPHN.StyleController = this.layoutControl1;
            this.txtPHN.TabIndex = 7;
            // 
            // cboSEX
            // 
            this.cboSEX.Location = new System.Drawing.Point(368, 36);
            this.cboSEX.Name = "cboSEX";
            this.cboSEX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSEX.Properties.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboSEX.Size = new System.Drawing.Size(85, 20);
            this.cboSEX.StyleController = this.layoutControl1;
            this.cboSEX.TabIndex = 6;
            // 
            // txtPNM
            // 
            this.txtPNM.Location = new System.Drawing.Point(91, 36);
            this.txtPNM.Name = "txtPNM";
            this.txtPNM.Size = new System.Drawing.Size(194, 20);
            this.txtPNM.StyleController = this.layoutControl1;
            this.txtPNM.TabIndex = 5;
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(91, 12);
            this.txtPID.Name = "txtPID";
            this.txtPID.Properties.AllowFocused = false;
            this.txtPID.Properties.ReadOnly = true;
            this.txtPID.Size = new System.Drawing.Size(362, 20);
            this.txtPID.StyleController = this.layoutControl1;
            this.txtPID.TabIndex = 4;
            this.txtPID.TabStop = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(465, 255);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtPID;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(445, 24);
            this.layoutControlItem1.Text = "Patient ID:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtPNM;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(277, 24);
            this.layoutControlItem2.Text = "Name:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cboSEX;
            this.layoutControlItem3.Location = new System.Drawing.Point(277, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(168, 24);
            this.layoutControlItem3.Text = "Sex:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtPHN;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(277, 24);
            this.layoutControlItem4.Text = "Contact:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtADR;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(445, 24);
            this.layoutControlItem6.Text = "Address:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtHIS;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(445, 42);
            this.layoutControlItem7.Text = "Medical History:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtCMT;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(445, 63);
            this.layoutControlItem8.Text = "Comments:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnSave;
            this.layoutControlItem9.Location = new System.Drawing.Point(271, 201);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(82, 34);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnCancel;
            this.layoutControlItem10.Location = new System.Drawing.Point(363, 201);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(82, 34);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 201);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(271, 34);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(353, 201);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 34);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dtpDOB;
            this.layoutControlItem5.Location = new System.Drawing.Point(277, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(168, 24);
            this.layoutControlItem5.Text = "Date of Birth:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(76, 13);
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 255);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPatient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patient";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpDOB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDOB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHIS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtADR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPHN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSEX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPNM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.MemoEdit txtCMT;
        private DevExpress.XtraEditors.MemoEdit txtHIS;
        private DevExpress.XtraEditors.TextEdit txtADR;
        private DevExpress.XtraEditors.TextEdit txtPHN;
        private DevExpress.XtraEditors.ComboBoxEdit cboSEX;
        private DevExpress.XtraEditors.TextEdit txtPNM;
        private DevExpress.XtraEditors.TextEdit txtPID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.DateEdit dtpDOB;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}