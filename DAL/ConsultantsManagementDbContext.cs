using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataAccess
{
    public class ConsultantsManagementDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Consultants> Consultants { get; set; }
        public DbSet<Meetings> Meetings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-R79UV6KB\\SQLEXPRESS;Database=ConsultantsManagement;Trusted_Connection=True;MultipleActiveResultSets=true;",
                    x => x.MigrationsAssembly("DAL"));
            }
        }
    }
}
