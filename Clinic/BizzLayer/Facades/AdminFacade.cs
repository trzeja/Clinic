using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizzLayer.Facades
{
    //operacje na bazie danych dla admina
    //AdminEditForm - czy przy Add nie powinno być też loginu do podania?
    static public class AdminFacade
    {

        public static IQueryable<User> GetUsers(User searchCrit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from element in dc.Users
                             where
                             (String.IsNullOrEmpty(searchCrit.fname) || element.fname.StartsWith(searchCrit.fname))
                             &&
                             (String.IsNullOrEmpty(searchCrit.lname) || element.lname.StartsWith(searchCrit.lname))
                             &&
                             (String.IsNullOrEmpty(searchCrit.roles) || element.roles.Equals(searchCrit.roles))
                             &&
                             (searchCrit.retire_date.Equals(null) || element.retire_date.Equals(searchCrit.retire_date))
                         select element;
            return result;
        }

        public static void AddUser(User user, string medRightNo = null)
        {
            //walidacja
            //pole username powinno być dostępne do edycji tylko w add
            //by nie mozna bylo wpisac sobie nowego rekordu
            DataClasses1DataContext dc = new DataClasses1DataContext();
            dc.Users.InsertOnSubmit(user);

            if (user.roles == "LABW")
            {
                dc.Laboratory_workers.InsertOnSubmit(new Laboratory_worker { user_name = user.user_name });
            }
            else if (user.roles == "LABM")
            {
                dc.Laboratory_managers.InsertOnSubmit(new Laboratory_manager { user_name = user.user_name });
            }
            else if (user.roles == "DOC")
            {
                dc.Doctors.InsertOnSubmit(new Doctor { user_name = user.user_name, medical_right_no = medRightNo });
            }
            else if (user.roles=="REG")
            {
                dc.Registrations.InsertOnSubmit(new Registration { user_name = user.user_name });
            }

            dc.SubmitChanges();
        }

        public static void ModifyUser(User user)
        {
            //walidacja
            //tu pole username niedostępne do edycji
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var old = from element in dc.Users
                      where element.user_name.Equals(user.user_name)
                      select element;
            if (user.password != null)
            {
                old.FirstOrDefault().password = user.password;
            }
            old.FirstOrDefault().roles = user.roles;
            old.FirstOrDefault().fname = user.fname;
            old.FirstOrDefault().lname = user.lname;
            //albo reture date albo znowu null
            old.FirstOrDefault().retire_date = user.retire_date;
            dc.SubmitChanges();
        }
    }
}
