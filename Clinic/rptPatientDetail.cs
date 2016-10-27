using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Clinic
{
    public partial class rptPatientDetail : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPatientDetail()
        {
            InitializeComponent();
        }

        public rptPatientDetail(string PatientID)
        {
            InitializeComponent();

            ServerToClient sc = new ServerToClient();
            Patient p = new Patient();
            PatientContext px = new PatientContext();
            TreatmentContext tx = new TreatmentContext();

            p = px.GetPatient(PatientID);

            lbPID.Text = p.ID;
            lbPNM.Text = p.PatientName;
            lbADR.Text = p.Address;
            lbHIS.Text = p.MedicalHistory;
            lbCMT.Text = p.Comments;
            lbPHN.Text = p.PhoneNo;
            lbAGE.Text = p.Age.ToString();
            lbSEX.Text = p.Sex;

            sc = tx.GetTreatments(PatientID);
            DataSource = sc.DT;

            GroupField tdt = new GroupField("TreatmentDate");
            GroupHeader1.GroupFields.Add(tdt);
            XRSummary amt = new XRSummary();
           
            lbTDT.DataBindings.Add("Text", null, "TreatmentDate", "{0:dd-MM-yyyy}");
            lbCMP.DataBindings.Add("Text", null, "MainComplain");
            lbEXM.DataBindings.Add("Text", null, "Examination");
            lbTMP.DataBindings.Add("Text", null, "Treatment");
            lbMED.DataBindings.Add("Text", null, "Medicine");
            lbAMT.DataBindings.Add("Text", null, "Amount", "{0:C2}");
            lbTAM.DataBindings.Add("Text", null, "Amount");

            amt.FormatString = "{0:C2}";
            amt.Running = SummaryRunning.Report;

            lbTAM.Summary = amt;
            

        }
    }
}
