using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Clinic
{
    public partial class rptPatientList : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPatientList()
        {
            InitializeComponent();

            ServerToClient sc = new ServerToClient();
            PatientContext px = new PatientContext();

            sc = px.GetPatients();

            DataSource = sc.DT;

            lbPID.DataBindings.Add("Text", null, "ID");
            lbPNM.DataBindings.Add("Text", null, "PatientName");
            lbAGE.DataBindings.Add("Text", null, "Age");
            lbSEX.DataBindings.Add("Text", null, "Sex");
            lbHIS.DataBindings.Add("Text", null, "MedicalHistory");
            lbCMT.DataBindings.Add("Text", null, "Comments");
            lbADR.DataBindings.Add("Text", null, "Address");
            lbPHN.DataBindings.Add("Text", null, "PhoneNo");
        }

    }
}
