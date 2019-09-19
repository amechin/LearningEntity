using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEntityByCodeFirst.Entities.CodeFirst
{
    public class SMContext : DbContext
    {
        public DbSet<MailServer> MailServers { get; set; }
        public DbSet<Sender> Senders { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Utilisateur> Utilisateur { get; set; }
        public DbSet<Address> Addresse { get; set; }

        internal void Update(Employee emp)
        {
            throw new NotImplementedException();
        }
    }
}
