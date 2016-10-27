#region Note
/*
{**************************************************************************************************************}
{  This file is automatically created when you open the Scheduler Control smart tag                            }
{  *and click Create Customizable Appointment Dialog.                                                          }
{  It contains a a descendant of the default appointment editing form created by visual inheritance.           }
{  In Visual Studio Designer add an editor that is required to edit your appointment custom field.             }
{  Modify the LoadFormData method to get data from a custom field and fill your editor with data.              }
{  Modify the SaveFormData method to retrieve data from the editor and set the appointment custom field value. }
{  The code that displays this form is automatically inserted                                                  }
{  *in the EditAppointmentFormShowing event handler of the SchedulerControl.                                   }
{                                                                                                              }
{**************************************************************************************************************}
*/
#endregion Note

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraEditors;

namespace Clinic.Controls
{
    public partial class CustomAppointmentForm : DevExpress.XtraScheduler.UI.AppointmentForm
    {
        int _patient;
        public CustomAppointmentForm()
        {
            InitializeComponent();
            LoadPatients();
        }
        public CustomAppointmentForm(DevExpress.XtraScheduler.SchedulerControl control, Appointment apt)
            : base(control, apt)
        {
            InitializeComponent();
            LoadPatients();
        }
        public CustomAppointmentForm(DevExpress.XtraScheduler.SchedulerControl control, Appointment apt, bool openRecurrenceForm)
            : base(control, apt, openRecurrenceForm)
        {
            InitializeComponent();
            LoadPatients();
        }
        /// <summary>
        /// Add your code to obtain a custom field value and fill the editor with data.
        /// </summary>
        public override void LoadFormData(Appointment appointment)
        {
            if (appointment.CustomFields["PatientID"] == null)
            {
                luePTN.EditValue = null;
                btnPTN.Enabled = false;
            }
            else
            {
                _patient = Convert.ToInt32(appointment.CustomFields["PatientID"]);
                luePTN.EditValue = _patient;
                btnPTN.Enabled = true;
            }
            //base.LoadFormData(appointment);
        }
        /// <summary>
        /// Add your code to retrieve a value from the editor and set the custom appointment field.
        /// </summary>
        public override bool SaveFormData(Appointment appointment)
        {
            if (!dxVP.Validate()) return false;
            appointment.CustomFields["PatientID"] = luePTN.EditValue;
            return true;
        }
        /// <summary>
        /// Add your code to notify that any custom field is changed. Return true if a custom field is changed, otherwise false.
        /// </summary>
        public override bool IsAppointmentChanged(Appointment appointment)
        {
//            if (!dxVP.Validate()) return;
            if (_patient == Convert.ToInt32(appointment.CustomFields["PatientID"]))
                return false;
            else
                return true;
        }

        private void LoadPatients()
        {
            ServerToClient sc = new ServerToClient();
            PatientContext px = new PatientContext();
            sc = px.GetPatients();
            luePTN.Properties.DataSource = sc.DT;
            luePTN.Properties.DisplayMember = "PatientName";
            luePTN.Properties.ValueMember = "ID";
        }

        private void luePTN_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Index == 1)
            {
                frmPatient frm = new frmPatient();
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    Patient p = new Patient();
                    p.ID = frm.ID;
                    p.PatientName = frm.PatientName;
                    p.Sex = frm.Sex;
                    p.DateOfBirth = frm.DateOfBirth;
                    p.PhoneNo = frm.PhoneNo;
                    p.Address = frm.Address;
                    p.Comments = frm.Comments;
                    p.MedicalHistory = frm.MedicalHistory;

                    ServerToClient sc = new ServerToClient();
                    PatientContext px = new PatientContext();
                    sc = px.AddPatient(p);

                    if(sc.Message == null)
                    {
                        LoadPatients();
                        luePTN.EditValue = sc.Count;
                    }
                    else
                    {
                        XtraMessageBox.Show(sc.Message);
                    }
                }
            }
        }

        private void btnPTN_Click(object sender, EventArgs e)
        {
            string PID = luePTN.EditValue.ToString();
            
            frmPatientDataUpdate frm = new frmPatientDataUpdate(PID);
            frm.ShowDialog();
        }

        private void luePTN_EditValueChanged(object sender, EventArgs e)
        {
            if (luePTN.EditValue != null)
                btnPTN.Enabled = true;
            else
                btnPTN.Enabled = false;
        }
    }
}
