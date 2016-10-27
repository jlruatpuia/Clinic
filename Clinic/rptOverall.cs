using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Clinic
{
    public partial class rptOverall : DevExpress.XtraReports.UI.XtraReport
    {
        public rptOverall()
        {
            InitializeComponent();
        }

        public rptOverall(DateTime df, DateTime dt)
        {
            InitializeComponent();
            ServerToClient sc = new ServerToClient();
            TreatmentContext tx = new TreatmentContext();
            sc = tx.OverallView(df, dt);
            if (DateTime.Equals(df, dt))
                lbHDR.Text = "PATIENT REPORT ON " + dt.ToShortDateString();
            else
                lbHDR.Text = "PATIENT REPORT BETWEEN " + df.ToShortDateString() + " AND " + dt.ToShortDateString();
            DataSource = sc.DT;
            XRSummary sam = new XRSummary();
            XRSummary gam = new XRSummary();

            GroupField tdt = new GroupField("TreatmentDate");
            GroupHeader1.GroupFields.Add(tdt);

            lbTDT.DataBindings.Add("Text", null, "TreatmentDate", "{0:dd-MM-yyyy}");
            lbPID.DataBindings.Add("Text", null, "PatientID");
            lbPNM.DataBindings.Add("Text", null, "PatientName");
            lbADR.DataBindings.Add("Text", null, "Address");
            lbPHN.DataBindings.Add("Text", null, "PhoneNo");
            lbAMT.DataBindings.Add("Text", null, "Amount", "{0:C2}");
            lbSAM.DataBindings.Add("Text", null, "Amount", "{0:C2}");
            lbGAM.DataBindings.Add("Text", null, "Amount", "{0:C2}");
            sam.FormatString = "{0:C2}";
            sam.Running = SummaryRunning.Group;
            gam.FormatString = "{0:C2}";
            gam.Running = SummaryRunning.Report;
            lbSAM.Summary = sam;
            lbGAM.Summary = gam;
        }
    }
}
