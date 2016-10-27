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
using System.IO;

namespace Clinic
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            dlaf.LookAndFeel.SkinName = Properties.Settings.Default.WindowTheme;
            MySettings.GeometryFromString(Properties.Settings.Default.WindowGeometry, this);
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

        private void nDoctor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.WindowTheme = dlaf.LookAndFeel.ActiveSkinName;
            Properties.Settings.Default.WindowGeometry = MySettings.GeometryToString(this);
            Properties.Settings.Default.Save();
        }

        private void bSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            new frmSettings().ShowDialog();
        }

        private void bBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog() { RootFolder = Environment.SpecialFolder.Desktop };
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                string fn = DateTime.Now.Year.ToString("0000") + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00") + DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00") + DateTime.Now.Second.ToString("00");
                File.Copy(Application.StartupPath + @"\clinic.mdb", fbd.SelectedPath + @"\" + fn + ".bak");
            }
        }

        private void bRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Backup file|*.bak|All Files|*.*" };
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                File.Copy(ofd.FileName, Application.StartupPath + @"\clinic.mdb", true);
            }
        }
    }
}