using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactuurTest1.Models
{
    public class Mailbox
    {
        public int MailboxID { set; get; }
        public String Name { set; get; }
        public String Description { set; get; }
        public String URI { get; set; }

        public virtual ICollection<Postman> Postman { get; set; }
    }   
}
