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

namespace Clinic
{
    public partial class frmPatient : XtraForm
    {
        public string ID { get; set; }
        public string PatientName { get; set; }
        public string RelativeName { get; set; }
        public string Relationship { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string MedicalHistory { get; set; }
        public string Comments { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }

        public frmPatient()
        {
            InitializeComponent();
            cboSEX.SelectedIndex = 0;
            PatientContext px = new PatientContext();
            txtPID.Text = px.PatientID();
        }

        public frmPatient(string PatientID)
        {
            InitializeComponent();
            ID = PatientID;

            Patient p = new Patient();
            PatientContext px = new PatientContext();
            p = px.GetPatient(ID);

            txtPID.Text = ID;
            txtPNM.Text = p.PatientName;
            cboSEX.Text = p.Sex;
            dtpDOB.DateTime = p.DateOfBirth;
            txtPHN.Text = p.PhoneNo;
            txtADR.Text = p.Address;
            txtCMT.Text = p.Comments;
            txtHIS.Text = p.MedicalHistory;
            btnSave.Text = "&Update";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (btnSave.Text == "&Save")
            {
                ID = txtPID.Text;
                PatientName = txtPNM.Text;
                Sex = cboSEX.Text;
                DateOfBirth = dtpDOB.DateTime.Date;
                PhoneNo = txtPHN.Text;
                Address = txtADR.Text;
                Comments = txtCMT.Text;
                MedicalHistory = txtHIS.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                ServerToClient sc = new ServerToClient();
                PatientContext px = new PatientContext();
                Patient p = new Patient();
                p.ID = txtPID.Text;
                p.PatientName = txtPNM.Text;
                p.Sex = cboSEX.Text;
                p.DateOfBirth = dtpDOB.DateTime.Date;
                p.PhoneNo = txtPHN.Text;
                p.Address = txtADR.Text;
                p.Comments = txtCMT.Text;
                p.MedicalHistory = txtHIS.Text;

                sc = px.UpdatePatient(p);

                if(sc.Message == null)
                {
                    XtraMessageBox.Show("Patient detail updated!");
                    Close();
                }
                else
                {
                    XtraMessageBox.Show(sc.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}