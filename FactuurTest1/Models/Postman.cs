using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactuurTest1.Models
{
    public class Postman
    {
        public int PostmanID { get; set; }
        public int AddressID { get; set; }
        public int MailboxID { get; set; }

        public virtual Mailbox Mailbox { get; set; }
        public virtual Address Address { get; set; }
    }
}
