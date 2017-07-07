using EntityFramework.APP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.APP
{
    public class SchoolContext:DbContext
    {
        public SchoolContext():base()
        {

        }

        public DbSet<Student> students { get; set; }
        public DbSet<Standard> standards { get; set; }

    }
}
