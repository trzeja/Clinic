using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzLayer.Model
{
    public class PatientWithAddress
    {
        public string id;
        public string fname;
        public string lname;
        public string pesel;
        
        public string place;
        public string street;
        public string zipcode;
        public string house;
        public string flat;

        public PatientWithAddress(
            string id = null,
            string fname = null,
            string lname = null,
            string pesel = null,
            string place = null,
            string street = null,
            string zipcode = null,
            string house = null,
            string flat = null)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.pesel = pesel;
            this.place = place;
            this.street = street;
            this.zipcode = zipcode;
            this.house = house;
        }    
    }
}
