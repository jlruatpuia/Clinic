using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{

    public class ServerToClient
    {
        public DataTable DT { get; set; }
        public DataSet DS { get; set; }
        public int Count { get; set; }
        public string Message { get; set; }

    }

    class MyClass
    {
        
    }

    public class Patient
    {
        public string ID { get; set; }
        public string PatientName { get; set; }
        public string RelativeName { get; set; }
        public string Relationship { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string MedicalHistory { get; set; }
        public string Comments { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
    }

    public class Treatments
    {
        public int ID { get; set; }
        public string PatientID { get; set; }
        public string MainComplain { get; set; }
        public string Examination { get; set; }
        public string Treatment { get; set; }
        public DateTime TreatmentDate { get; set; }
        public string Medicine { get; set; }
        public double Amount { get; set; }
    }

    public class Medicine
    {
        public int ID { get; set; }
        public string MedicineName { get; set; }
    }

    public class ClinicReport
    {
        public int TreatmentID { get; set; }
        public DateTime TreatmentDate { get; set; }
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Complain { get; set; }
        public string Examination { get; set; }
        public string Treatment { get; set; }
        public string[] Medicine { get; set; }
    }

    public class Doctor
    {
        public int UniqueID { get; set; }
        public string ResourceName { get; set; }
        public string Designation { get; set; }
        public string Institution { get; set; }
        public string RegdNo { get; set; }
    }

    public class PatientContext
    {
        OleDbConnection cm = new OleDbConnection(Properties.Settings.Default.cs);

        public ServerToClient GetPatients()
        {
            ServerToClient sc = new ServerToClient();
            OleDbCommand cmd = new OleDbCommand("SELECT ID, PatientName, DateOfBirth, YEAR(NOW)-YEAR(DateOfBirth) AS Age, Sex, MedicalHistory, Comments, Address, PhoneNo FROM Patient", cm);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            sc.DT = ds.Tables[0];
            return sc;
        }

        public Patient GetPatient(string PatientID)
        {
            Patient p = new Patient();
            OleDbCommand cmd = new OleDbCommand("SELECT ID, PatientName, DateOfBirth, YEAR(NOW)-YEAR(DateOfBirth) AS Age, Sex, MedicalHistory, Comments, Address, PhoneNo FROM Patient WHERE ID='" + PatientID + "'", cm);
            try
            {
                cm.Open();
                OleDbDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    p.ID = PatientID;
                    p.PatientName = rd[1].ToString();
                    p.DateOfBirth = DateTime.Parse(rd[2].ToString());
                    p.Age = Convert.ToInt32(rd[3]);
                    p.Sex = rd[4].ToString();
                    p.MedicalHistory = rd[5].ToString();
                    p.Comments = rd[6].ToString();
                    p.Address = rd[7].ToString();
                    p.PhoneNo = rd[8].ToString();
                }
            }
            catch {; }
            finally { cm.Close(); }
            return p;
        }

        public string PatientID()
        {
            int yy = 0;
            int mm = 0;
            int sn = 0; ;
            OleDbCommand cmd = new OleDbCommand("SELECT TOP 1 MID(ID, 1, 4), MID(ID, 5, 2), MID(ID, 7) FROM Patient WHERE MID(ID, 1, 4)= CSTR(YEAR(NOW)) AND MID(ID, 5, 2) = CSTR(MONTH(NOW)) ORDER BY ID DESC", cm);
            try
            {
                cm.Open();
                OleDbDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    yy = Convert.ToInt32(rd[0]);
                    mm = Convert.ToInt32(rd[1]);
                    sn = Convert.ToInt32(rd[2]);
                }
                else
                {
                    yy = DateTime.Now.Year;
                    mm = DateTime.Now.Month;
                    sn = 0;
                }
            }
            catch {
                yy = DateTime.Now.Year;
                mm = DateTime.Now.Month;
                sn = 0;
            }
            finally { cm.Close(); }

            return yy.ToString("0000") + mm.ToString("00") + (sn + 1).ToString("0000");
        }

        public ServerToClient AddPatient(Patient p)
        {
            ServerToClient sc = new ServerToClient();
            OleDbCommand cmd;
            cmd = new OleDbCommand("INSERT INTO Patient(ID, PatientName, DateOfBirth, Sex, MedicalHistory, Comments, Address, PhoneNo) VALUES (@PID, @PNM, @DOB, @SEX, @MHS, @CMT, @ADR, @PHN)", cm);
            cmd.Parameters.AddWithValue("@PID", p.ID);
            cmd.Parameters.AddWithValue("@PNM", p.PatientName);
            cmd.Parameters.AddWithValue("@DOB", p.DateOfBirth);
            cmd.Parameters.AddWithValue("@SEX", p.Sex);
            cmd.Parameters.AddWithValue("@MHS", p.MedicalHistory);
            cmd.Parameters.AddWithValue("@CMT", p.Comments);
            cmd.Parameters.AddWithValue("@ADR", p.Address);
            cmd.Parameters.AddWithValue("@PHN", p.PhoneNo);
            try
            {
                cm.Open();
                cmd.ExecuteNonQuery();

                cmd = new OleDbCommand("SELECT DMAX('ID', 'Patient')", cm);
                sc.Count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch(Exception ex) { sc.Message = ex.Message; }
            finally { cm.Close(); }
            return sc;
        }

        public ServerToClient UpdatePatient(Patient p)
        {
            ServerToClient sc = new ServerToClient();
            OleDbCommand cmd = new OleDbCommand("UPDATE Patient SET PatientName=@PNM, DateOfBirth=@DOB, Sex=@SEX, MedicalHistory=@MHS, Comments=@CMT, Address=@ADR, PhoneNo=@PHN WHERE ID='" + p.ID + "'", cm);
            cmd.Parameters.AddWithValue("@PNM", p.PatientName);
            cmd.Parameters.AddWithValue("@DOB", p.DateOfBirth);
            cmd.Parameters.AddWithValue("@SEX", p.Sex);
            cmd.Parameters.AddWithValue("@MHS", p.MedicalHistory);
            cmd.Parameters.AddWithValue("@CMT", p.Comments);
            cmd.Parameters.AddWithValue("@ADR", p.Address);
            cmd.Parameters.AddWithValue("@PHN", p.PhoneNo);
            try
            {
                cm.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { sc.Message = ex.Message; }
            finally { cm.Close(); }
            return sc;
        }

        public ServerToClient DeletePatient(string PatientID)
        {
            ServerToClient sc = new ServerToClient();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Patient WHERE ID='" + PatientID + "'", cm);
            try
            {
                cm.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { sc.Message = ex.Message; }
            finally { cm.Close(); }
            return sc;
        }

        public ServerToClient GetTreatments(string PatientID)
        {
            ServerToClient sc = new ServerToClient();
            OleDbCommand cmd = new OleDbCommand("SELECT ID, MainComplain, TreatmentDate, PatientID FROM Treatments WHERE PatientID='" + PatientID + "'", cm);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            sc.DT = ds.Tables[0];
            return sc;
        }

    }

    public class TreatmentContext
    {
        OleDbConnection cm = new OleDbConnection(Properties.Settings.Default.cs);

        public ServerToClient GetTreatments(string PatientID)
        {
            ServerToClient sc = new ServerToClient();
            OleDbCommand cmd = new OleDbCommand("SELECT ID, PatientID, MainComplain, Examination, Treatment, Medicine, TreatmentDate, Amount FROM Treatments WHERE PatientID='" + PatientID + "'", cm);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            sc.DT = ds.Tables[0];
            return sc;
        }

        public Treatments GetTreatments(int TreatmentID)
        {
            Treatments t = new Treatments();
            OleDbCommand cmd = new OleDbCommand("SELECT ID, PatientID, MainComplain, Examination, Treatment, Medicine, TreatmentDate, Amount FROM Treatments WHERE ID=" + TreatmentID, cm);
            try
            {
                cm.Open();
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                t.ID = TreatmentID;
                t.PatientID = rd[1].ToString();
                t.MainComplain = rd[2].ToString();
                t.Examination = rd[3].ToString();
                t.Treatment = rd[4].ToString();
                t.Medicine = rd[5].ToString();
                t.TreatmentDate = DateTime.Parse(rd[6].ToString());
                t.Amount = Convert.ToDouble(rd[7]);
            }
            catch {; }
            finally { cm.Close(); }
            return t;
        }

        public ServerToClient AddTreatment(Treatments t)
        {
            ServerToClient sc = new ServerToClient();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Treatments(PatientID, MainComplain, Examination, Treatment, Medicine, TreatmentDate, Amount) VALUES (@PID, @CMP, @EXM, @TRM, @MED, @TDT, @AMT)", cm);
            cmd.Parameters.AddWithValue("@PID", t.PatientID);
            cmd.Parameters.AddWithValue("@CMP", t.MainComplain);
            cmd.Parameters.AddWithValue("@EXM", t.Examination);
            cmd.Parameters.AddWithValue("@TRM", t.Treatment);
            cmd.Parameters.AddWithValue("@MED", t.Medicine);
            cmd.Parameters.AddWithValue("@TDT", t.TreatmentDate);
            cmd.Parameters.AddWithValue("@AMT", t.Amount);
            try
            {
                cm.Open();
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("SELECT DMAX('ID', 'Treatments')", cm);
                sc.Count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch(Exception ex) { sc.Message = ex.Message; }
            finally { cm.Close(); }
            return sc;
        }

        public ServerToClient UpdateTreatment(Treatments t)
        {
            ServerToClient sc = new ServerToClient();
            OleDbCommand cmd = new OleDbCommand("UPDATE Treatments SET PatientID=@PID, MainComplain=@CMP, Examination=@EXM, Treatment=@TRM, Medicine=@MED, TreatmentDate=@TDT, Amount=@AMT WHERE ID=" + t.ID, cm);
            cmd.Parameters.AddWithValue("@PID", t.PatientID);
            cmd.Parameters.AddWithValue("@CMP", t.MainComplain);
            cmd.Parameters.AddWithValue("@EXM", t.Examination);
            cmd.Parameters.AddWithValue("@TRM", t.Treatment);
            cmd.Parameters.AddWithValue("@MED", t.Medicine);
            cmd.Parameters.AddWithValue("@TDT", t.TreatmentDate);
            cmd.Parameters.AddWithValue("@AMT", t.Amount);
            try
            {
                cm.Open();
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("SELECT DMAX('ID', 'Treatments')", cm);
                sc.Count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex) { sc.Message = ex.Message; }
            finally { cm.Close(); }
            return sc;
        }

        public ServerToClient DeleteTreatment(int TreatmentID)
        {
            ServerToClient sc = new ServerToClient();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Treatments WHERE ID=" + TreatmentID, cm);
            try
            {
                cm.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { sc.Message = ex.Message; }
            finally { cm.Close(); }
            return sc;
        }

        public ServerToClient OverallView()
        {
            ServerToClient sc = new ServerToClient();
            OleDbCommand cmd = new OleDbCommand("SELECT Treatments.ID AS TreatmentID, Treatments.TreatmentDate, Patient.ID AS PatientID, Patient.PatientName, Patient.Address, Patient.PhoneNo, Treatments.Amount FROM Patient INNER JOIN(Treatments LEFT OUTER JOIN Gallery ON Treatments.ID = Gallery.TreatmentID) ON Patient.ID = Treatments.PatientID", cm);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            sc.DT = ds.Tables[0];
            return sc;
        }

        public ServerToClient OverallView(DateTime datefr, DateTime dateto)
        {
            string df = datefr.Year.ToString("0000") + "-" + datefr.Month.ToString("00") + "-" + datefr.Day.ToString("00");
            string dt = dateto.Year.ToString("0000") + "-" + dateto.Month.ToString("00") + "-" + dateto.Day.ToString("00");
            ServerToClient sc = new ServerToClient();
            OleDbCommand cmd = new OleDbCommand("SELECT Treatments.ID AS TreatmentID, Treatments.TreatmentDate, Patient.ID AS PatientID, Patient.PatientName, Patient.Address, Patient.PhoneNo, Treatments.Amount FROM Patient INNER JOIN(Treatments LEFT OUTER JOIN Gallery ON Treatments.ID = Gallery.TreatmentID) ON Patient.ID = Treatments.PatientID WHERE Treatments.TreatmentDate BETWEEN #" + df + "# AND #" + dt + "#", cm);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            sc.DT = ds.Tables[0];
            return sc;
        }

        public ClinicReport GetClinicReport(int TreatmentID)
        {
            ClinicReport c = new ClinicReport();
            OleDbCommand cmd = new OleDbCommand("SELECT Treatments.ID AS TreatmentID, Treatments.TreatmentDate, Patient.ID AS PatientID, Patient.PatientName, Patient.Address, Patient.PhoneNo, Patient.Sex, Year(Now())-Year(Patient.DateOfBirth) AS Age, Treatments.MainComplain, Treatments.Examination, Treatments.Treatment, Treatments.Medicine FROM Patient INNER JOIN Treatments ON Patient.ID = Treatments.PatientID WHERE Treatments.ID=" + TreatmentID, cm);
            try
            {
                cm.Open();
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                c.TreatmentID = Convert.ToInt32(rd[0]);
                c.TreatmentDate = DateTime.Parse(rd[1].ToString());
                c.PatientID = rd[2].ToString();
                c.PatientName = rd[3].ToString();
                c.Address = rd[4].ToString();
                c.PhoneNo = rd[5].ToString();
                c.Sex = rd[6].ToString();
                c.Age = Convert.ToInt32(rd[7]);
                c.Complain = rd[8].ToString();
                c.Examination = rd[9].ToString();
                c.Treatment = rd[10].ToString();
                string[] med = rd[11].ToString().Split(',').ToArray();
                c.Medicine = med;
                rd.Close();
            }
            catch {; }
            finally { cm.Close(); }
            return c;
        }
    }

    public class MedicineContext
    {
        OleDbConnection cm = new OleDbConnection(Properties.Settings.Default.cs);

        public ServerToClient AddMedicine(Medicine m)
        {
            ServerToClient sc = new ServerToClient();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Medicine (MedicineName) VALUES (@MDN)", cm);
            cmd.Parameters.AddWithValue("@MDN", m.MedicineName);
            try
            {
                cm.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { sc.Message = ex.Message; }
            finally { cm.Close(); }
            return sc;
        }

        public ServerToClient GetMedicines()
        {
            ServerToClient sc = new ServerToClient();
            OleDbCommand cmd = new OleDbCommand("SELECT DISTINCT MedicineName FROM Medicine ORDER BY MedicineName", cm);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            sc.DT = ds.Tables[0];
            sc.Count = ds.Tables[0].Rows.Count;
            return sc;
        }
    }

    //public class DoctorContext
    //{
    //    OleDbConnection cm = new OleDbConnection(Properties.Settings.Default.cs);

    //    public ServerToClient GetDoctors()
    //    {
    //        ServerToClient sc = new ServerToClient();
    //        OleDbCommand cmd = new OleDbCommand("SELECT UniqueID, ResourceName, Designation, Institution, RegdNo FROM Resources ORDER BY ResourceName", cm);
    //        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
    //        DataSet ds = new DataSet();
    //        da.Fill(ds);
    //        sc.DT = ds.Tables[0];
    //        sc.Count = ds.Tables[0].Rows.Count;
    //        return sc;
    //    }

    //    public ServerToClient AddDoctor(Doctor d)
    //    {
    //        ServerToClient sc = new ServerToClient();
    //        OleDbCommand cmd = new OleDbCommand("")
    //    }
    //}
}
