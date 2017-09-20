using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer;


namespace BizzLayer.Facades
{
    static public class DoctorFacade
    {
        public static void FinishVisit(Visit visit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var oldVisit = from v in dc.Visits
                           where v.id_visit == visit.id_visit
                           select v;
            oldVisit.FirstOrDefault().description = visit.description;
            oldVisit.FirstOrDefault().diagnosis = visit.diagnosis;
            oldVisit.FirstOrDefault().state = visit.state;
            oldVisit.FirstOrDefault().execution_cancel_datetime = visit.execution_cancel_datetime;
            dc.SubmitChanges();
        }

        public static int GetDoctorIdByUsername(string username)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from doctor in dc.Doctors
                         where doctor.user_name == username
                         select doctor.id_doc;
            return result.FirstOrDefault();
        }

        public static IQueryable GetDoctors(User searchCrit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from p in dc.Users
                         where ((String.IsNullOrEmpty(searchCrit.fname) || p.fname.StartsWith(searchCrit.fname)) && (String.IsNullOrEmpty(searchCrit.lname) || p.lname.StartsWith(searchCrit.lname))) && p.roles == "DOC" && (p.retire_date == null
                        || p.retire_date.Value < DateTime.Now.Date)
                         join d in dc.Doctors on p.user_name equals d.user_name
                         into joined
                         from j in joined.DefaultIfEmpty()

                         select new { j.id_doc, p.fname, p.lname, j.medical_right_no };
            return result;

            //var result2 = from doctor in dc.Doctors
            //              where 
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
                         && visit.registration_date < (from visit2 in dc.Visits where visit2.id_visit == idVisit select visit2.registration_date).FirstOrDefault()
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
            return res.OrderBy(r => r.registration_date);


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

        public static string GetNameForExam(string code)
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

        //dodać datę mniejszą od obecnej wizyty
        public static IQueryable GetExamHist(int idPatient,int idVisit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = (from labexam in dc.Laboratory_examinations
                         join visit in dc.Visits on labexam.id_visit equals visit.id_visit
                         into joined
                         from j in joined
                         where (j.id_patient == idPatient) && (j.registration_date<(from visit2 in dc.Visits where visit2.id_visit == idVisit select visit2.registration_date).FirstOrDefault())
                         select new { labexam.code,type="Laboratory", order_date = new DateTime?(labexam.order_date), labexam.state, labexam.examination_execution_date, labexam.examination_approval_date, labexam.result, examId=labexam.id_laboratory_examination })
                         .Union(
           /* var resultPhy =*/ from labphy in dc.Physical_examinations
                            join visit in dc.Visits on labphy.id_visit equals visit.id_visit
                            into joined
                            from j in joined
                            where j.id_patient == idPatient && (j.registration_date < (from visit2 in dc.Visits where visit2.id_visit == idVisit select visit2.registration_date).FirstOrDefault())
                            select new { labphy.code, type = "Physical", order_date = new DateTime?(), state = "", examination_execution_date = labphy.execution_datetime, examination_approval_date = new DateTime?(), labphy.result,examId=labphy.id_physical_examination });
            //var resultSum = resultLab.ToList().Add(resultPhy.ToList());
            return result;
        }

        public static IQueryable GetExaminationsByVisit(int idVisit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = (from labexam in dc.Laboratory_examinations
                          join visit in dc.Visits on labexam.id_visit equals visit.id_visit
                          into joined
                          from j in joined
                          where j.id_visit == idVisit
                          select new { labexam.code, type = "Laboratory", order_date = new DateTime?(labexam.order_date), labexam.state, labexam.examination_execution_date, labexam.examination_approval_date, labexam.result, examId=labexam.id_laboratory_examination })
                         .Union(
           /* var resultPhy =*/ from labphy in dc.Physical_examinations
                                join visit in dc.Visits on labphy.id_visit equals visit.id_visit
                                into joined
                                from j in joined
                                where j.id_visit == idVisit
                                select new { labphy.code, type = "Physical", order_date = new DateTime?(), state = "", examination_execution_date = labphy.execution_datetime, examination_approval_date = new DateTime?(), labphy.result, examId=labphy.id_physical_examination });
            //var resultSum = resultLab.ToList().Add(resultPhy.ToList());
            return result;
        }
        public static List<string> GetPhysicalExamination(int idExam)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from phyexam in dc.Physical_examinations
                         join examdict in dc.Examination_dictionaries on phyexam.code equals examdict.code
                         into joined
                         from j in joined
                         where phyexam.id_physical_examination == idExam
                         select new {phyexam.code, j.name, phyexam.result };
            var list = new List<string>(new string[]{ result.FirstOrDefault().code, result.FirstOrDefault().name, result.FirstOrDefault().result });
            return list;
        }
    }
}
