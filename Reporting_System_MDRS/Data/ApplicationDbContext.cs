using MySql.Data.EntityFramework;
using Reporting_System_MDRS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reporting_System_MDRS.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("MySqlConnection") 
        {
            Database.SetInitializer<ApplicationDbContext>(null); // Disable Migrations        
        }

        public DbSet<Category> category { get; set; }
    }
}