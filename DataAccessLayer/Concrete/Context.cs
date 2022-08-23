using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<Call> Calls { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
