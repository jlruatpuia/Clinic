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
    }
}
