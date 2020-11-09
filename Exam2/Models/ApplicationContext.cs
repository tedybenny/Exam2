using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<users> Users { get; set; }
        public DbSet<pavilions> Pavilions { get; set; }

        public ApplicationContext()
        {
                Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;UserId=root;Password=root;database=mall;");
        }
    }
}
