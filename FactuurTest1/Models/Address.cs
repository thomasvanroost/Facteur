using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactuurTest1.Models
{
    public class Address
    {
        public int AddressID { set; get; }
        public String Firstname { set; get; }
        public String Lastname { set; get; }
        public String Emailaddress { set; get; }
        public String Streetname { set; get; }
        public String Number { set; get; }
        public String Postalcode { set; get; }
        public String Place { set; get; }

        public virtual ICollection<Postman> Postmen { set; get; }
    }
}