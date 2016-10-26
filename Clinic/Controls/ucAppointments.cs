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
using DevExpress.XtraScheduler;
using System.Data.OleDb;

namespace Clinic.Controls
{
    public partial class ucAppointments : XtraUserControl
    {
        public ucAppointments()
        {
            InitializeComponent();
            sch.Start = DateTime.Now;
            schStorage.AppointmentsInserted += new PersistentObjectsEventHandler(OnAppointmentModified);
            schStorage.AppointmentsChanged += new PersistentObjectsEventHandler(OnAppointmentModified);
            schStorage.AppointmentsDeleted += new PersistentObjectsEventHandler(OnAppointmentModified);
            sch.ActiveViewType = SchedulerViewType.WorkWeek;
        }

        private void ucAppointments_Load(object sender, EventArgs e)
        {
            daRes.Fill(dsClinic.Resources);
            daApp.Fill(dsClinic.Appointments);
            daApp.Adapter.RowUpdated += new OleDbRowUpdatedEventHandler(daApp_RowUpdated);
        }

        private void OnAppointmentModified(object sender, PersistentObjectsEventArgs e)
        {
            daApp.Update(dsClinic);
            dsClinic.AcceptChanges();
        }

        void daApp_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert)
            {
                int id = 0;
                using (OleDbCommand cmd = new OleDbCommand("SELECT DMAX('UniqueID', 'Appointments')", daApp.Connection))
                {
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                e.Row["UniqueID"] = id;
            }
        }

        private void sch_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            CustomAppointmentForm form = new CustomAppointmentForm(sender as SchedulerControl, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }
        }
    }
}
