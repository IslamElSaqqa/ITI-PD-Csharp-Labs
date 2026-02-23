using EFCore_Example.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Example.Context
{
    public class CFDbContext : DbContext
    {
        public string? ConnectionString;

        public CFDbContext() {
            ConnectionString = "Data Source= .\\SQLEXPRESS; Initial Catalog=PD46_EFCore; Integrated Security=True; TrustServerCertificate=True";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Department> Departments { set; get; }
    
    
    }
}
