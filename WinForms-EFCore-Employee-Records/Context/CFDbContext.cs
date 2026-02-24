using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_EFCore_Employee_Records.Models;

namespace WinForms_EFCore_Employee_Records.Context
{
    public  class CFDbContext : DbContext
    {
        public string? ConnectionString;

        public CFDbContext()
        {
            ConnectionString = "Data Source= .\\SQLEXPRESS; Initial Catalog=PD_EFCore_Lab; Integrated Security=True; TrustServerCertificate=True";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Employee> Employees { set; get; }


    }
}
