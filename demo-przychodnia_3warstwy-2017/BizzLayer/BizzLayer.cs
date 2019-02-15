using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


// 
namespace BizzLayer
{
    static public class SLabFacade
    {
        public static IQueryable GetResearchData(DateTime data)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var test = DateTime.Today;
            if (data == DateTime.Today)
            {
                var res = from research in dc.Exam_Labs
                          where (research.dt_zle.Date == test) 
                          select
                          new
                          {

                              research.Id_Exam_lab,
                              research.Code,
                              research.Id_Lab,
                              research.Id_SLab,
                              research.dt_zle,
                              research.dt_wyk,
                              research.dt_zat,
                              research.Id_Vis,
                              research.status


                          };
                return res;

            }
            else
            {
                var res = from research in dc.Exam_Labs
                          where (research.dt_zle.Date == data) 
                          select
                          new
                          {
                              research.Id_Exam_lab,
                              research.Code,
                              research.Id_Lab,
                              research.Id_SLab,
                              research.dt_zle,
                              research.dt_wyk,
                              research.dt_zat,
                              research.Id_Vis,
                              research.status

                          };
                return res;
            }


        }
        public static IQueryable GetResearch(Visit searchCrit)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from research in dc.Exam_Labs
                     
                      select
                       new
                       {
                           research.Id_Exam_lab,
                           research.Code,
                           research.Id_Lab,
                           research.Id_SLab,
                           research.dt_zle,
                           research.dt_wyk,
                           research.dt_zat,
                           research.Id_Vis,
                           research.status
                       };
            return res;
        }

        public static void UpdateExamData(Exam_Lab lab)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {
                var res = (from el in dc.Exam_Labs
                           where el.Id_Exam_lab == lab.Id_Exam_lab
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                res.supervisor_comments = lab.supervisor_comments;
                res.Id_SLab = lab.Id_SLab;

                dc.SubmitChanges();

            }

        }
        public static void AcceptExamData(Exam_Lab lab)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {
                var res = (from el in dc.Exam_Labs
                           where el.Id_Exam_lab == lab.Id_Exam_lab
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                res.status = 3;
                res.dt_zat = DateTime.Now;
                

                dc.SubmitChanges();

            }

        }

        public static void DeclineExamData(Exam_Lab lab)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {
                var res = (from el in dc.Exam_Labs
                           where el.Id_Exam_lab == lab.Id_Exam_lab
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                res.status = 4;
               
                res.dt_zat = DateTime.Now;
                

                dc.SubmitChanges();

            }

        }
    }



    static public class LabFacade
    {
        public static IQueryable GetResearchData(DateTime data)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var test = DateTime.Today;
            if (data == DateTime.Today)
            {
                var res = from research in dc.Exam_Labs
                          where (research.dt_zle.Date == test) 
                          select
                          new
                          {
                          
                              research.Id_Exam_lab,
                              research.SL_Exam.name,
                              research.Id_Lab,
                              research.Id_SLab,
                              research.dt_zle,
                              research.dt_wyk,
                              research.dt_zat,
                              research.Id_Vis,
                              research.status
                             
                              
                          };
                return res;

            }
            else
            {
                var res = from research in dc.Exam_Labs
                          where (research.dt_zle.Date == data) 
                          select
                          new
                          {
                              research.Id_Exam_lab,
                              research.SL_Exam.name,
                              research.Id_Lab,
                              research.Id_SLab,
                              research.dt_zle,
                              research.dt_wyk,
                              research.dt_zat,
                              research.Id_Vis,
                              research.status

                          };
                return res;
            }


        }
        public static IQueryable GetResearch(Visit searchCrit)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from research in dc.Exam_Labs
                       
                      select
                       new
                       {
                           research.Id_Exam_lab,
                           research.SL_Exam.name,
                           research.Id_Lab,
                           research.Id_SLab,
                           research.dt_zle,
                           research.dt_wyk,
                           research.dt_zat,
                           research.Id_Vis,
                           research.status
                       };
            return res;
        }
        public static IQueryable<Exam_Lab> GetLabInfo(Exam_Lab searchCrit)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from el in dc.Exam_Labs
                      where
                      (searchCrit.Id_Exam_lab == 0) || (el.Id_Exam_lab == searchCrit.Id_Exam_lab)

                      select el;
            return res;
        }

        public static void UpdateExamData(Exam_Lab lab)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {
                var res = (from el in dc.Exam_Labs
                           where el.Id_Exam_lab == lab.Id_Exam_lab
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                res.results = lab.results;
                res.Id_Lab = lab.Id_Lab;
          
                dc.SubmitChanges();

            }

        }

        public static void SendExamData(Exam_Lab lab)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {
                var res = (from el in dc.Exam_Labs
                           where el.Id_Exam_lab == lab.Id_Exam_lab
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                res.status = 2;
                res.dt_wyk = DateTime.Now;

                dc.SubmitChanges();

            }

        }
    }



     static public class RegistrationFacade
    {
        public static IQueryable<Patient> GetPatients(Patient searchCrit)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from el in dc.Patients
                      where
                      (String.IsNullOrEmpty(searchCrit.LastName) || el.LastName.StartsWith(searchCrit.LastName))
                      &&
                      ((searchCrit.Id_Pat == 0) || el.Id_Pat == searchCrit.Id_Pat)
                      &&
                      (String.IsNullOrEmpty(searchCrit.FirstName) || el.FirstName.StartsWith(searchCrit.FirstName))
                      &&
                       (String.IsNullOrEmpty(searchCrit.PESEL) || el.PESEL.StartsWith(searchCrit.PESEL))
                      
                      select el;
            return res;
        }
        /// <summary>
        /// nie musi być void
        /// </summary>
        /// <param name="pat"></param>
        public static void UpdatePatientData(Patient pat)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {
                var res = (from el in dc.Patients
                           where el.Id_Pat == pat.Id_Pat
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                res.LastName = pat.LastName;
                res.FirstName = pat.FirstName;
                res.PESEL = pat.PESEL;
                dc.SubmitChanges();

            }

        }
        public static void NewPatientData(Patient pat)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {
                var res = new Patient();
            
                res.LastName = pat.LastName;
                res.FirstName = pat.FirstName;
                res.PESEL = pat.PESEL;

                dc.Patients.InsertOnSubmit(res);
                dc.SubmitChanges();

            }

        }
        public static void NewVisitData(Visit pat)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {
                var res = new Visit();

                res.Status = pat.Status;
                res.DT_Reg = pat.DT_Reg;
                res.Id_Pat = pat.Id_Pat;
                res.Id_Doc = pat.Id_Doc;
                res.Description = " ";
                res.Diagnosis = " ";
                res.Id_Reg = pat.Id_Reg;

                dc.Visits.InsertOnSubmit(res);
                dc.SubmitChanges();

            }

        }

        public static void DeleteVisitData(int pat)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {
                var res = (from el in dc.Visits
                           where el.Id_Vis == pat
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                dc.Visits.DeleteOnSubmit(res);
                try
                {
                    dc.SubmitChanges();
                }
                catch
                {
                    return;
                }  

            }

        }


        public static IQueryable GetDoctors(Doctor searchCrit)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from doc in dc.Doctors
                      select
                       new
                       {
                           doc.Id_Doc,
                           doc.Name,
                           doc.Surname,
                       };
            return res;
        }
        public static IQueryable GetVisits(Visit searchCrit)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from vis in dc.Visits
                      select
                       new
                       {
                           vis.Id_Vis,
                           FirstName = vis.Patient.FirstName,
                           LastName = vis.Patient.LastName,
                           vis.Description,
                           vis.Diagnosis,
                           vis.DT_Reg,
                           vis.Status,
                           vis.Doctor.Surname
                       };
            return res;
        }
        public static void UpdateVisitData(Visit vis)
        {
            return;
        }

        public static IQueryable GetVisitsData(DateTime data)      
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var test = DateTime.Today;
            if (data == DateTime.Today)
            {
                var res = from vis in dc.Visits
                          where (vis.DT_Reg.Date == test)
                          select
                          new
                          {
                              vis.Id_Vis,
                              FirstName = vis.Patient.FirstName,
                              LastName = vis.Patient.LastName,
                              vis.Description,
                              vis.Diagnosis,
                              vis.DT_Reg,
                              vis.Status,
                              vis.Doctor.Surname
                          };
                return res;

            }
            else
            {
                var res = from vis in dc.Visits
                          where (vis.DT_Reg.Date == data)
                          select
                          new
                          {
                              vis.Id_Vis,
                              FirstName = vis.Patient.FirstName,
                              LastName = vis.Patient.LastName,
                              vis.Description,
                              vis.Diagnosis,
                              vis.DT_Reg,
                              vis.Status,
                              vis.Doctor.Surname

                          };
                return res;
            }


        }


    }
    //============================================================================================================================
    static public class DoctorFacade
    {
        public static IQueryable GetVisits(Visit searchCrit)  //dodac sort by?
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from vis in dc.Visits
                      select
                       new
                       {
                           vis.Id_Vis,
                           FirstName = vis.Patient.FirstName,
                           LastName = vis.Patient.LastName,
                           vis.Description,
                           vis.Diagnosis,
                           vis.Status,
                           vis.DT_Reg,
                       };

            return res;
        }


        public static IQueryable GetVisits(DateTime data)       //pokazanie lekarzowi dzisiejszych zaplanowanych wizyt
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            DateTime test = DateTime.Today;
            if (data == DateTime.Today)
            {
                var res = from vis in dc.Visits
                          where (vis.DT_Reg.Date == test)
                          select
                          new
                          {
                              vis.Id_Vis,
                              FirstName = vis.Patient.FirstName,
                              LastName = vis.Patient.LastName,
                              vis.Description,
                              vis.Diagnosis,
                              vis.Status,
                              vis.DT_Reg
                          };
                return res;

            }
            else
            {
                var res = from vis in dc.Visits
                          where (vis.DT_Reg.Date == data)
                          select
                          new
                          {
                              vis.Id_Vis,
                              FirstName = vis.Patient.FirstName,
                              LastName = vis.Patient.LastName,
                              vis.Description,
                              vis.Diagnosis,
                              vis.Status,
                              vis.DT_Reg

                          };
                return res;
            }


        }
        public static void UpdateVisitDesc(Visit vis)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {
                var res = (from el in dc.Visits
                           where el.Id_Vis == vis.Id_Vis
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                res.Description = vis.Description;
                dc.SubmitChanges();

            }

        }

        public static void UpdateVisitDiag(Visit vis)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {
                var res = (from el in dc.Visits
                           where el.Id_Vis == vis.Id_Vis
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                res.Diagnosis = vis.Diagnosis;
                dc.SubmitChanges();

            }

        }

        public static void UpdateVisitStat(Visit vis)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {
                var res = (from el in dc.Visits
                           where el.Id_Vis == vis.Id_Vis
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                res.Status = vis.Status;
                dc.SubmitChanges();

            }

        }


        public static IQueryable SearchPatients_in_Visits(Patient searchCrit)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from vis in dc.Visits
                      where
                      (vis.Patient.FirstName == searchCrit.FirstName || vis.Patient.LastName == searchCrit.LastName)
                      select
                      new
                      {
                          vis.Id_Vis,
                          vis.Patient.FirstName,
                          vis.Patient.LastName,
                          vis.Description,
                          vis.Diagnosis,
                          vis.Status,
                          vis.DT_Reg
                      };
            return res;

        }





    }
    //=======================================================================================================================================
    static public class ExamFacade
    {
        public static IQueryable GetSL_Exam()
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from ex in dc.SL_Exams
                      where ex.type == "Lab"
                      select
                       new
                       {
                           ex.Code,
                           ex.type,
                           ex.name,
                       };
            return res;
        }

        public static IQueryable GetSL_Exam_Fiz()
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from ex in dc.SL_Exams
                      where ex.type == "Fiz"
                      select
                       new
                       {
                           ex.Code,
                           ex.type,
                           ex.name,
                       };
            return res;
        }

        public static void NewExam_Lab(Exam_Lab exam)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {
                var res = new Exam_Lab();

                res.Id_Vis = exam.Id_Vis;
                res.doctor_comments = exam.doctor_comments;
                res.dt_zle = exam.dt_zle;
                res.Code = exam.Code;
                res.status = exam.status;
                dc.Exam_Labs.InsertOnSubmit(res);
                dc.SubmitChanges();

            }

        }
        public static IQueryable GetExam_Lab()
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from ex in dc.Exam_Labs
                      select
                       new
                       {
                           ex.Id_Exam_lab,
                           ex.doctor_comments,
                           ex.dt_zle,
                           ex.Id_Vis,
                           ex.Code,
                       };
            return res;
        }

        public static IQueryable GetSL_Exam(SL_Exam searchCrit)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from ex in dc.SL_Exams
                      where
                      (ex.type == searchCrit.type || ex.name == searchCrit.name)
                      select
                      new
                      {
                          ex.Code,
                          ex.type,
                          ex.name,
                      };

            return res;
        }

        public static IQueryable GetSL_Exam_Code(SL_Exam searchCrit)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from ex in dc.SL_Exams
                      where
                      (ex.Code == searchCrit.Code)
                      select
                      new
                      {
                          ex.Code,
                          ex.type,
                          ex.name,
                      };
            return res;
        }

        public static IQueryable GetExam_Lab(Exam_Lab exam)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from ex in dc.Exam_Labs
                      where (ex.Id_Vis == exam.Id_Vis)
                      select
                       new
                       {
                           ex.Id_Exam_lab,
                           ex.results,
                           ex.dt_wyk,
                           ex.supervisor_comments,
                           ex.dt_zat,
                           ex.status,
                           ex.Code,
                       };
            return res;
        }

        public static void NewExam_Fiz(Exam_Physical exam)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {

                var res = new Exam_Physical();

                res.Id_Vis = exam.Id_Vis;
                res.Result = exam.Result;
                res.Code = exam.Code;
                dc.Exam_Physicals.InsertOnSubmit(res);
                dc.SubmitChanges();

            }

        }

        public static IQueryable GetExam_Fiz(Exam_Physical exam)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from ex in dc.Exam_Physicals
                      where (ex.Id_Vis == exam.Id_Vis)
                      select
                       new
                       {
                           ex.Id_exam_ph,
                           ex.Result,
                           ex.Code,
                           ex.Id_Vis,
                       };
            return res;
        }

        public static IQueryable GetResults(Exam_Physical exam)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from ex in dc.Exam_Physicals
                      where (ex.Id_Vis == exam.Id_Vis)
                      select
                       new
                       {
                           ex.Id_exam_ph,
                           ex.SL_Exam.name,
                           ex.Result,
                           ex.Code,

                       };
            return res;
        }
    }
    //=======================================================================================================================================




    static public class AdminFacade
    {
        public static void NewDoctorData(Doctor doc)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {


                var res = new Doctor();
                res.Name = doc.Name;
                res.Surname = doc.Surname;
                res.uname = doc.uname;
                res.NPWZ = doc.NPWZ;
                dc.Doctors.InsertOnSubmit(res);
                dc.SubmitChanges();

            }

        }
        public static void NewLabData(Lab lb)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {


                var res = new Lab();
                res.Name = lb.Name;
                res.Surname = lb.Surname;
                res.uname = lb.uname;
                dc.Lab.InsertOnSubmit(res);
                dc.SubmitChanges();

            }

        }
        public static void NewSLabData(SLab lb)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {

               
                var res = new SLab();
                res.Name = lb.Name;
                res.Surname = lb.Surname;
                res.uname = lb.uname;
                dc.SLabs.InsertOnSubmit(res);
                dc.SubmitChanges();
               
            }

        }
            public static void NewRegData(Register rg)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {


                var res = new Register();
                res.Name = rg.Name;
                res.Surname = rg.Surname;
                res.uname = rg.uname;
                dc.Register.InsertOnSubmit(res);
                dc.SubmitChanges();

            }

        }
        public static void NewUserData(User usr)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {
                var res = new User();
                res.uname = usr.uname;
                res.pass = CreateMD5(usr.pass);
                res.role = usr.role;
                res.DT_retire = usr.DT_retire;
                dc.Users.InsertOnSubmit(res);
                dc.SubmitChanges();

            }

        }
        public static IQueryable<User> GetUsers(User searchCrit)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from el in dc.Users
                      where
                      (String.IsNullOrEmpty(searchCrit.uname) || el.uname.StartsWith(searchCrit.uname))
                      &&
                      ((searchCrit.DT_retire == default(DateTime)) || el.DT_retire == searchCrit.DT_retire)
                      &&
                      (String.IsNullOrEmpty(searchCrit.role) || el.role.StartsWith(searchCrit.role))

                      select el;
            return res;
        }
        
        public static void UpdateUserData(User usr)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {
                var res = (from el in dc.Users
                           where el.uname == usr.uname
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                res.DT_retire = usr.DT_retire;
                
                dc.SubmitChanges();

            }

        }
        public static void DeleteUserData(string uname)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {
                var res = (from el in dc.Users
                           where el.uname == uname
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                dc.Users.DeleteOnSubmit(res);
                dc.SubmitChanges();

            }

        }

        public static string CreateMD5(string input) // funkcja md5
        {
            // input string do kalkulacji MD5
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                //  Konwersja tablicy bitów na hex string 
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public static string GetUsersLogin(User check_usr) // funkcja sprawdzająca uzytkownika w bazie. 
        {
            var db = new DataClassesClinicDataContext();
            User check = null;
            check = db.Users.SingleOrDefault(p => p.uname == check_usr.uname && p.pass == CreateMD5(check_usr.pass)); // sprawdzamy czy check_usr znajduje się w bazie. 
            if (check != null)
            {
                return check.role; // jeśli nie jest null, to zwracamy stringa z rolą. 
            }
            return null;

            
        }

        public static int GetUsersLoginLab(User check_usr) // funkcja sprawdzająca uzytkownika w bazie. 
        {
            var db = new DataClassesClinicDataContext();
            User check = null;
            check = db.Users.SingleOrDefault(p => p.uname == check_usr.uname && p.pass == CreateMD5(check_usr.pass)); // sprawdzamy czy check_usr znajduje się w bazie. 
            if (check != null)
            {
                Lab test = null;
                test = db.Lab.SingleOrDefault(p => p.uname == check_usr.uname);
                if (test != null)
                {
                    return test.Id_Lab;
                }
            }
            return 0;


        }

        public static int GetUsersLoginSLab(User check_usr) // funkcja sprawdzająca uzytkownika w bazie. 
        {
            var db = new DataClassesClinicDataContext();
            User check = null;
            check = db.Users.SingleOrDefault(p => p.uname == check_usr.uname && p.pass == CreateMD5(check_usr.pass)); // sprawdzamy czy check_usr znajduje się w bazie. 
            if (check != null)
            {
                SLab test = null;
                test = db.SLabs.SingleOrDefault(p => p.uname == check_usr.uname);
                if (test != null)
                {
                    return test.Id_SLab;
                }
            }
            return 0;


        }

        public static int GetUsersLoginReg(User check_usr) // funkcja sprawdzająca uzytkownika w bazie. 
        {
            var db = new DataClassesClinicDataContext();
            User check = null;
            check = db.Users.SingleOrDefault(p => p.uname == check_usr.uname && p.pass == CreateMD5(check_usr.pass)); // sprawdzamy czy check_usr znajduje się w bazie. 
            if (check != null)
            {
                Register test = null;
                test = db.Register.SingleOrDefault(p => p.uname == check_usr.uname);
                if (test != null)
                {
                    return test.Id_Reg;
                }
            }
            return 0;


        }




    }
}