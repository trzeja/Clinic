using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void AddUser(User user)
        {
            //walidacja
            //pole username powinno być dostępne do edycji tylko w add
            //by nie mozna bylo wpisac sobie nowego rekordu
            DataClasses1DataContext dc = new DataClasses1DataContext();
            dc.Users.InsertOnSubmit(user);
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
            old.FirstOrDefault().password = user.password;
            old.FirstOrDefault().roles = user.roles;
            old.FirstOrDefault().fname = user.fname;
            old.FirstOrDefault().lname = user.lname;
            //albo reture date albo znowu null
            old.FirstOrDefault().retire_date = user.retire_date;
            dc.SubmitChanges();
        }
    }
}
