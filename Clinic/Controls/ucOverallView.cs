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
    public partial class ucOverallView : DevExpress.XtraEditors.XtraUserControl
    {
        ServerToClient sc;// = new ServerToClient();
        TreatmentContext tx;// = new TreatmentContext();

        public ucOverallView()
        {
            InitializeComponent();

            sc = new ServerToClient();
            tx = new TreatmentContext();

            beiFR.EditValue = DateTime.Now;
            beiTO.EditValue = DateTime.Now;

            ShowData();
        }

        private void bClinicReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int tid = Convert.ToInt32(grv.GetFocusedRowCellValue(colTID));
            new rptClinicReport(tid).ShowPreviewDialog();
        }

        private void bShow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            DateTime dtFR = DateTime.Parse(beiFR.EditValue.ToString());
            DateTime dtTO = DateTime.Parse(beiTO.EditValue.ToString());

            sc = tx.OverallView(dtFR, dtTO);

            grd.DataSource = sc.DT;
        }
    }
}
