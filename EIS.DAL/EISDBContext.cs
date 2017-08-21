using EIS.BOL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIS.DAL
{
    public class EISDBContext : DbContext
    {
        public EISDBContext():base("EISDB3")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EISDBContext, EIS.DAL.Migrations.Configuration>());
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Employee> Employees { get; set; }

     
    }
}
