using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


// 
namespace BizzLayer
{


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

        public static IQueryable GetDoctors(Doctor searchCrit)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from doc in dc.Doctors
                      select
                       new
                       {
                           //FirstName = vis.Patient.FirstName,
                           //LastName = vis.Patient.LastName,
                           doc.Id_Doc,
                           doc.Name,
                           doc.Surname,
                       };
            return res;
        }

    }

    static public class DoctorFacade
    {
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
                           vis.Diagnosis
                       };
            return res;
        }
        public static void UpdateVisitData(Visit vis)
        {
            return;
        }
    }

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
                res.pass = usr.pass;
                res.role = usr.role;
                res.DT_retire = usr.DT_retire;
                dc.Users.InsertOnSubmit(res);
                dc.SubmitChanges();

            }

        }
    }
}