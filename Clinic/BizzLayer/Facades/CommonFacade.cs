using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer;

namespace BizzLayer.Facades
{
    static public class CommonFacade
    {
        public static User GetUserByUsername(String username)
        {
            // TODO 
            // czy nie powinnam sprawdzac zanim go wybiore czy jeszcze istnieje w bazie?
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from element in dc.Users
                         where element.user_name.Equals(username)
                         select element;
            return result.FirstOrDefault();
        }

        public static Patient GetPatientByVisit(int idVisit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from patient in dc.Patients
                         where patient.id_patient == (from visit in dc.Visits where visit.id_visit == idVisit select visit.id_patient).FirstOrDefault()
                         select patient;
            return result.FirstOrDefault();
        }

        public static Laboratory_examination GetLabExam(int idExam)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from labexam in dc.Laboratory_examinations
                         where labexam.id_laboratory_examination == idExam
                         select labexam;
            return result.FirstOrDefault();
        }

        public static string GetExamCodeName(string code)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var name = from examdir in dc.Examination_dictionaries
                          where examdir.code == code
                          select examdir.name;
            return code + " " +name.FirstOrDefault();
        }

        public static Doctor GetDoctorByVisit(int idVisit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from doctor in dc.Doctors
                         where doctor.id_doc == (from visit in dc.Visits where visit.id_visit == idVisit select visit.id_doctor).FirstOrDefault()
                         select doctor;
            return result.FirstOrDefault();
        }

        public static Laboratory_worker GetLabW(int idLabw)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from labw in dc.Laboratory_workers
                         where labw.id_laboratory_worker == idLabw
                         select labw;
            return result.FirstOrDefault();
        }

        public static Laboratory_manager GetLabM(int idLabm)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from labm in dc.Laboratory_managers
                         where labm.id_laboratory_manager == idLabm
                         select labm;
            return result.FirstOrDefault();
        }
    }
}
