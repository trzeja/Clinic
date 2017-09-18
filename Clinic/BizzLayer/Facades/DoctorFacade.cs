using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BizzLayer.Facades
{
    static public class DoctorFacade
    {

        public static int GetDoctorIdByUsername(string username)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from doctor in dc.Doctors
                         where doctor.user_name == username
                         select doctor.id_doc;
            return result.FirstOrDefault();
        }

        //public static IQueryable GetVisitsFromToday(int idDoctor, DateTime currentDate)
        //{
        //    DataClasses1DataContext dc = new DataClasses1DataContext();
        //    var result = from p in dc.Patients
        //              join v in dc.Visits on p.id_patient equals v.id_patient
        //              into joined
        //              from j in joined.DefaultIfEmpty()
        //              where (currentDate.Date == j.registration_date.Date) && (j.id_doctor == idDoctor) && (j.state == "REG")
        //              select new { p.fname, p.lname, p.PESEL, j.state, j.registration_date, j.id_visit };
        //    return result;
        //}

        public static String GetVisitState(int idVisit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from visit in dc.Visits
                         where visit.id_visit == idVisit
                         select visit.state;
            return result.FirstOrDefault().ToString();
        }

        public static IQueryable GetExaminationsByVisit(int idVisit)
        {
            return null;
        }

        public static Visit GetVisitById(int idVisit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from visit in dc.Visits
                         where visit.id_visit == idVisit
                         select visit;
            return result.FirstOrDefault();
        }

        public static Doctor GetDoctorByVisit(int idVisit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from doctor in dc.Doctors
                         join visit in dc.Visits on doctor.id_doc equals visit.id_doctor
                         where visit.id_visit == idVisit
                         select doctor;
            return result.FirstOrDefault();
        }

        public static Patient GetPatientByVisit(int idVisit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from patient in dc.Patients
                         join visit in dc.Visits on patient.id_patient equals visit.id_patient
                         where visit.id_visit == idVisit
                         select patient;
            return result.FirstOrDefault();
        }

        public static IQueryable GetVisitsByPatient(int idPatient, int idVisit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from visit in dc.Visits
                         join doctor in dc.Doctors on visit.id_doctor equals doctor.id_doc
                         where visit.id_patient == idPatient
                         && visit.registration_date <= (from visit2 in dc.Visits where visit2.id_visit == idVisit select visit2.registration_date).FirstOrDefault()
                         orderby visit.registration_date, visit.execution_cancel_datetime, visit.state
                         select new { visit.registration_date, visit.execution_cancel_datetime, visit.state, doctor.User.fname, doctor.User.lname, visit.id_visit };
            return result;
        }

        public static IQueryable GetPatientsWithAdresses(int idDoctor,int idPatient, Visit visit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from p in dc.Patients
                      join v in dc.Visits on p.id_patient equals v.id_patient
                      into joined
                      from j in joined.DefaultIfEmpty()
                      where (((j.state == visit.state || visit.state == "") && ((j.id_patient == idPatient) || (idPatient == 0))) && (j.id_doctor == idDoctor) && ((visit.registration_date.Date == j.registration_date.Date) || (visit.registration_date == DateTime.ParseExact("01.01.1754 00:00:00", "dd.MM.yyyy HH:mm:ss",
                                        System.Globalization.CultureInfo.InvariantCulture))))
                      select new { p.fname, p.lname, p.PESEL, j.state, j.registration_date,j.id_visit };
            return res;


        }

        public static IQueryable GetLaboratoryExaminationType()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = 
               (from dbo in dc.Examination_dictionaries
                where dbo.type == 'L'
                select dbo.code).Distinct().OrderBy(name => name);
            return result;
        }

        public static IQueryable GetPhysicalExaminationType()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result =
               (from dbo in dc.Examination_dictionaries
                where dbo.type == 'P'
                select dbo.code).Distinct().OrderBy(name => name);
            return result;
        }

        public static string GetNameForExam(int code)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from ed in dc.Examination_dictionaries
                         where ed.code == code
                         select ed.name;
            return result.FirstOrDefault();
        }

        public static void AddLabExam(Laboratory_examination lab)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            dc.Laboratory_examinations.InsertOnSubmit(lab);
            dc.SubmitChanges();
        }

        public static void AddPhyExam(Physical_examination phy)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            dc.Physical_examinations.InsertOnSubmit(phy);
            dc.SubmitChanges();
        }

    }
}
