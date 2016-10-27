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
using System.IO;
using DevExpress.XtraReports.UI;

namespace Clinic
{
    public partial class frmSettings : DevExpress.XtraEditors.XtraForm
    {
        public frmSettings()
        {
            InitializeComponent();
            Settings g = new Settings();
            txtCNM.Text = g.ClinicName;
            txtAD1.Text = g.Address1;
            txtAD2.Text = g.Address2;
            txtAD3.Text = g.Address3;
            txtPH1.Text = g.Phone1;
            txtPH2.Text = g.Phone2;
            txtIMG.Text = Application.StartupPath + "\\logo.jpg";
            picIMG.Image = Image.FromFile(txtIMG.Text);
        }

        private void txtIMG_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image Files|*.jpg;*.png;*.gif;*.bmp|All Files|*.*" };
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                picIMG.Image = Image.FromFile(ofd.FileName);
                txtIMG.Text = ofd.FileName;
                //string ext = ofd.DefaultExt;
                //File.Copy(ofd.FileName, Application.StartupPath + @"\logo." + ext);
            }
        }

        private void bPreview_Click(object sender, EventArgs e)
        {
            rptPreview rpt = new rptPreview();
            Settings g = new Settings();

            rpt.lbCNM.Text = g.ClinicName;
            rpt.lbADR.Text = g.Address1 + "\n" + g.Address2 + "\n" + g.Address3;
            rpt.lbPHN.Text = "Phone No: " + g.Phone1 + ", " + g.Phone2;
            rpt.picIMG.Image = Image.FromFile(Application.StartupPath + @"\logo.jpg");
            rpt.ShowPreviewDialog();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            Settings g = new Settings();
            g.ClinicName = txtCNM.Text;
            g.Address1 = txtAD1.Text;
            g.Address2 = txtAD2.Text;
            g.Address3 = txtAD3.Text;
            g.Phone1 = txtPH1.Text;
            g.Phone2 = txtPH2.Text;
            File.Copy(txtIMG.Text, Application.StartupPath + @"\logo.jpg", true);
        }

        private void bCancel_Click(object sender, EventArgs e)
        {

        }
    }
}