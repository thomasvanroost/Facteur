using FactuurTest1.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FactuurTest1.DAL
{
    public class PostmanContext : DbContext
    {
        public PostmanContext()
            : base("PostmanContext")
        { }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Postman> Postmen { get; set; }
        public DbSet<Mailbox> Mailboxes { get; set; }

        // this methone makes the models singual tables in de db.. just naming..
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
         
    }
}