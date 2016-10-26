using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace Clinic
{
    public partial class rptClinicReport : DevExpress.XtraReports.UI.XtraReport
    {
        public rptClinicReport()
        {
            InitializeComponent();
        }

        public rptClinicReport(int TreatmentID)
        {
            InitializeComponent();
            //reatments.ID AS TreatmentID, Treatments.TreatmentDate, Patient.ID AS PatientID, Patient.PatientName, Patient.Address, Patient.PhoneNo, Patient.Sex, Year(Now())-Year(Patient.DateOfBirth) AS Age, Treatments.MainComplain, Treatments.Examination, Treatments.Treatment, Treatments.Medicine
            ClinicReport c = new ClinicReport();
            TreatmentContext tx = new TreatmentContext();
            c = tx.GetClinicReport(TreatmentID);

            lbTDT.Text = c.TreatmentDate.ToShortDateString();
            lbPID.Text = c.PatientID;
            lbPNM.Text = c.PatientName;
            lbADR.Text = c.Address;
            lbAGE.Text = c.Age.ToString();
            lbSEX.Text = c.Sex;
            lbCMP.Text = c.Complain;
            lbEXM.Text = c.Examination;
            lbTMP.Text = c.Treatment;
            lbMED.Text = "";
            foreach(string med in c.Medicine)
            {
                lbMED.Text += med;
                lbMED.Text += Environment.NewLine;
            }

        }
    }
}
