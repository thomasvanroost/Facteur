using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FactuurTest1.Models;

namespace FactuurTest1.DAL
{
    public class PostmanInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PostmanContext>
    {
        protected override void Seed(PostmanContext context)
        {
            var addresses = new List<Address>
            {
            //new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Address{Firstname="Thomas", Lastname="Van Roost", Emailaddress="thomasvanroost@gmail;com", Streetname="Koningin Astridlaan", Number="22 C202", Postalcode="2800", Place="Mechelen"},
            new Address{Firstname="Rob", Lastname="Heyman", Emailaddress="rob@gmail;com", Streetname="Kardinaalnogietsstraat", Number="229", Postalcode="2800", Place="Mechelen"},
            new Address{Firstname="Sara", Lastname="Feskens", Emailaddress="sarafeskens@gmail;com", Streetname="Koningin Astridlaan", Number="22 C202", Postalcode="2800", Place="Mechelen"}
            };

            addresses.ForEach(s => context.Addresses.Add(s));
            context.SaveChanges();
            
            
            var mailboxes = new List<Mailbox>
            {
            new Mailbox{Name="Verjaardag Sara", Description="Verjaardags Feestje voor Sara's 27ste verjaardag", URI="sfbdp90"},
            new Mailbox{Name="Verjaardag Thomas", Description="Verjaardags Feestje voor Thomas's 32ste verjaardag", URI="sfbdp91"},
            new Mailbox{Name="Press Launch Facteur", Description="Offical presslaunch, presentations by Rob en Thomas", URI="sfbdp94"}
            };

            mailboxes.ForEach(s => context.Mailboxes.Add(s));
            context.SaveChanges();
            
            
            var postmen = new List<Postman>
            {
            
            //new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Postman{ MailboxID=2, AddressID=2},
            new Postman{ MailboxID=2, AddressID=1},
            new Postman{ MailboxID=3, AddressID=1}
            
            };
            postmen.ForEach(s => context.Postmen.Add(s));
            context.SaveChanges();
            
        }
    }
}