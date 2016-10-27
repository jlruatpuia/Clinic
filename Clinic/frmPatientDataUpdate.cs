using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using DevExpress.XtraReports.UI;

namespace Clinic
{
    public partial class frmPatientDataUpdate : XtraForm
    {
        public string PID { get; set; }
        public int TID { get; set; }

        public frmPatientDataUpdate()
        {
            InitializeComponent();
        }

        public frmPatientDataUpdate(string PatientID)
        {
            InitializeComponent();
            dtpVST.DateTime = DateTime.Now.Date;
            PID = PatientID;

            Patient p = new Patient();
            PatientContext px = new PatientContext();

            p = px.GetPatient(PatientID);
            txtPID.Text = p.ID;
            txtPNM.Text = p.PatientName;
            txtADR.Text = p.Address;
            txtPHN.Text = p.PhoneNo;

            MedicineContext mx = new MedicineContext();
            ServerToClient sc = new ServerToClient();
            sc = mx.GetMedicines();

            for(int i = 0; i<= sc.Count - 1; i++)
            {
                cboMED.Properties.Items.Add(sc.DT.Rows[i].ItemArray[0].ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ServerToClient sc = new ServerToClient();
            TreatmentContext tx = new TreatmentContext();
            Treatments t = new Treatments();
            t.ID = TID;
            t.PatientID = PID;
            t.MainComplain = txtCMP.Text;
            t.Examination = txtEXM.Text;
            t.Treatment = txtTRM.Text;
            string med = null;
            for (int i = 0; i < lstMED.Items.Count; i++)
            {
                med += lstMED.Items[i].ToString() + ",";
            }
            med.Remove(med.Length - 1);
            t.Medicine = med;
            t.TreatmentDate = dtpVST.DateTime;
            t.Amount =Convert.ToDouble( txtAMT.Text);

            sc = tx.AddTreatment(t);

            if(sc.Message == null)
            {
                if(XtraMessageBox.Show("Patient data updated!\nDo you want to print?", "Print Report?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new rptClinicReport(sc.Count).ShowPreviewDialog();
                    Close();
                }
                else
                {
                    XtraMessageBox.Show(sc.Message);
                }
            }
        }


        private void cboMED_KeyDown(object sender, KeyEventArgs e)
        {
            ServerToClient sc = new ServerToClient();
            MedicineContext mx = new MedicineContext();
            Medicine m = new Medicine();
            if (e.KeyCode == Keys.Enter)
            {
                if (!dxValidationProvider1.Validate()) return;
                if (cboMED.SelectedIndex == -1)
                {
                    m.MedicineName = cboMED.Text;
                    sc = mx.AddMedicine(m);
                }
                lstMED.Items.Add(cboMED.Text);
                cboMED.SelectedIndex = -1;
            }
        }

        private void lstMED_KeyDown(object sender, KeyEventArgs e)
        {
            if(lstMED.Items.Count > 0)
            {
                if(e.KeyCode == Keys.Delete)
                {
                    ArrayList temp = new ArrayList();
                    foreach(int index in lstMED.SelectedIndices)
                    {
                        temp.Add(lstMED.Items[index]);
                    }
                    foreach (object item in temp)
                        lstMED.Items.Remove(item);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}