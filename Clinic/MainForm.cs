using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Clinic.Controls;

namespace Clinic
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nApp_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucAppointments uc = new ucAppointments() { Dock = DockStyle.Fill };
            spl.Panel2.Controls.Clear();
            spl.Panel2.Controls.Add(uc);

            ribbon.MergeRibbon(uc.ribbonControl1);
            ribbon.SelectedPage = ribbon.MergedRibbon.SelectedPage;
        }

        private void nPatient_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucPatients uc = new ucPatients() { Dock = DockStyle.Fill };
            spl.Panel2.Controls.Clear();
            spl.Panel2.Controls.Add(uc);

            ribbon.MergeRibbon(uc.ribbonControl1);
            ribbon.SelectedPage = ribbon.MergedRibbon.SelectedPage;
        }

        private void nOverall_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucOverallView uc = new ucOverallView() { Dock = DockStyle.Fill };
            spl.Panel2.Controls.Clear();
            spl.Panel2.Controls.Add(uc);

            ribbon.MergeRibbon(uc.ribbonControl1);
            ribbon.SelectedPage = ribbon.MergedRibbon.SelectedPage;
        }
    }
}