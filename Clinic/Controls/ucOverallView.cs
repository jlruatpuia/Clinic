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

        private void bCurrentView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime dtFR = DateTime.Parse(beiFR.EditValue.ToString());
            DateTime dtTO = DateTime.Parse(beiTO.EditValue.ToString());
            new rptOverall(dtFR, dtTO).ShowPreviewDialog();
        }

        private void bFind_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bFind.Checked)
                grv.OptionsFind.AlwaysVisible = true;
            else
                grv.OptionsFind.AlwaysVisible = false;

        }

        private void bPD_XLS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel 2003 File|*.xls|All Files|*.*" };
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                int tid = Convert.ToInt32(grv.GetFocusedRowCellValue(colTID));
                new rptClinicReport(tid).ExportToXls(sfd.FileName);
            }
        }

        private void bPD_PDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF File|*.pdf|All Files|*.*" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                int tid = Convert.ToInt32(grv.GetFocusedRowCellValue(colTID));
                new rptClinicReport(tid).ExportToPdf(sfd.FileName);
            }
        }

        private void bPD_XLSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel 2007 File|*.xlsx|All Files|*.*" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                int tid = Convert.ToInt32(grv.GetFocusedRowCellValue(colTID));
                new rptClinicReport(tid).ExportToXlsx(sfd.FileName);
            }
        }

        private void bCV_PDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF File|*.pdf|All Files|*.*" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DateTime dtFR = DateTime.Parse(beiFR.EditValue.ToString());
                DateTime dtTO = DateTime.Parse(beiTO.EditValue.ToString());
                new rptOverall(dtFR, dtTO).ExportToPdf(sfd.FileName);
            }
        }

        private void bCV_XLS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel 2003 File|*.xls|All Files|*.*" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DateTime dtFR = DateTime.Parse(beiFR.EditValue.ToString());
                DateTime dtTO = DateTime.Parse(beiTO.EditValue.ToString());
                new rptOverall(dtFR, dtTO).ExportToXls(sfd.FileName);
            }
        }

        private void bCV_XLSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel 2007 File|*.xlsx|All Files|*.*" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DateTime dtFR = DateTime.Parse(beiFR.EditValue.ToString());
                DateTime dtTO = DateTime.Parse(beiTO.EditValue.ToString());
                new rptOverall(dtFR, dtTO).ExportToXlsx(sfd.FileName);
            }
        }
    }
}
