using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace Clinic.Controls
{
    public partial class ucPatients : XtraUserControl
    {
        ServerToClient sc;
        PatientContext px;
        public ucPatients()
        {
            InitializeComponent();
            LoadPatients();

            lbCMP.Text = "";
            lbEXM.Text = "";
            lbMED.Text = "";
            lbTMP.Text = "";
            lbAMT.Text = "";
        }

        void LoadPatients()
        {
            sc = new ServerToClient();
            px = new PatientContext();
            sc = px.GetPatients();
            grd.DataSource = sc.DT;
            if(grv.RowCount <= 0)
            {
                bEdit.Enabled = false;
                bDel.Enabled = false;
            }
            else
            {
                bEdit.Enabled = true;
                bDel.Enabled = true;
            }
        }


        private void bNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPatient frm = new frmPatient();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Patient p = new Patient();
                p.ID = frm.ID;
                p.PatientName = frm.PatientName;
                p.Sex = frm.Sex;
                p.DateOfBirth = frm.DateOfBirth;
                p.PhoneNo = frm.PhoneNo;
                p.Address = frm.Address;
                p.Comments = frm.Comments;
                p.MedicalHistory = frm.MedicalHistory;

                ServerToClient sc = new ServerToClient();
                PatientContext px = new PatientContext();
                sc = px.AddPatient(p);

                if (sc.Message == null)
                {
                    //LoadPatients();
                    //luePTN.EditValue = sc.Count;
                    XtraMessageBox.Show("New patient added successfully!");
                }
                else
                {
                    XtraMessageBox.Show(sc.Message);
                }
            }
        }

        private void grv_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            string pid = grv.GetFocusedRowCellValue(colPID).ToString();
            ServerToClient sc = new ServerToClient();
            PatientContext px = new PatientContext();
            sc = px.GetTreatments(pid);

            grdT.DataSource = sc.DT;

            grvT_FocusedRowChanged(null, null);
        }

        private void grvT_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int tid = Convert.ToInt32(grvT.GetFocusedRowCellValue(colTID));
            TreatmentContext tx = new TreatmentContext();
            Treatments t = new Treatments();

            t = tx.GetTreatments(tid);

            lbCMP.Text = t.MainComplain;
            lbEXM.Text = t.Examination;
            try
            {
                string txt = null;
                string[] med = t.Medicine.Split(',');
                for (int i = 0; i< med.Length; i++)
                {
                    txt += med[i].ToString() + Environment.NewLine;
                }
                txt = txt.TrimEnd(Environment.NewLine.ToCharArray());
                lbMED.Text = txt;
            }
            catch
            {
                lbMED.Text = t.Medicine;
            }
            
            lbTMP.Text = t.Treatment;
            lbAMT.Text = "₹ " + t.Amount.ToString();
        }

        private void bEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string pid = grv.GetFocusedRowCellValue(colPID).ToString();
            new frmPatient(pid).ShowDialog();
        }

        private void bDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you want to delete this patient record?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string pid = grv.GetFocusedRowCellValue(colPID).ToString();
                ServerToClient sc = new ServerToClient();
                PatientContext px = new PatientContext();
                sc = px.DeletePatient(pid);
                if(sc.Message == null)
                {
                    XtraMessageBox.Show("Patient ID " + pid + " deleted successfully!");
                    LoadPatients();
                }
                else
                {
                    XtraMessageBox.Show(sc.Message);
                }
            }
        }

        private void bPrintPatientDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string pid = grv.GetFocusedRowCellValue(colPID).ToString();
            new rptPatientDetail(pid).ShowPreviewDialog();
        }

        private void bPD_PDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string pid = grv.GetFocusedRowCellValue(colPID).ToString();
            rptPatientDetail rpt = new rptPatientDetail(pid);
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF File|*.pdf|All Files|*.*"};
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                rpt.ExportToPdf(sfd.FileName);
            }
        }

        private void bPD_XLS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string pid = grv.GetFocusedRowCellValue(colPID).ToString();
            rptPatientDetail rpt = new rptPatientDetail(pid);
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel 2003 File|*.xls|All Files|*.*" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                rpt.ExportToXls(sfd.FileName);
            }
        }

        private void bPD_XLSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string pid = grv.GetFocusedRowCellValue(colPID).ToString();
            rptPatientDetail rpt = new rptPatientDetail(pid);
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel 2007 File|*.xlsx|All Files|*.*" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                rpt.ExportToXlsx(sfd.FileName);
            }
        }

        private void bPrintPatientList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new rptPatientList().ShowPreviewDialog();
        }

        private void bPL_PDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF File|*.pdf|All Files|*.*" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                new rptPatientList().ExportToPdf(sfd.FileName);
            }
        }

        private void bPL_XLS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel 2003 File|*.xls|All Files|*.*" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                new rptPatientList().ExportToXls(sfd.FileName);
            }
        }

        private void bPL_XLSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel 2007 File|*.xlsx|All Files|*.*" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                new rptPatientList().ExportToXlsx(sfd.FileName);
            }
        }

        private void bFind_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bFind.Checked)
            {
                grv.OptionsFind.AlwaysVisible = true;
                findToolStripMenuItem.Checked = true;
            }
            else
            {
                grv.OptionsFind.AlwaysVisible = false;
                findToolStripMenuItem.Checked = false;
            }
        }

        private void grv_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                grv.FocusedRowHandle = e.HitInfo.RowHandle;
                cMenu.Show(grv.GridControl, e.Point);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bNew_ItemClick(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bEdit_ItemClick(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bDel_ItemClick(null, null);
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (findToolStripMenuItem.Checked)
            {
                grv.OptionsFind.AlwaysVisible = false;
                bFind.Checked = false;
            }
            else
            {
                grv.OptionsFind.AlwaysVisible = true;
                bFind.Checked = true;
            }
        }

        private void patientDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bPrintPatientDetail_ItemClick(null, null);

        }

        private void patientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bPrintPatientList_ItemClick(null, null);
        }
    }
}
