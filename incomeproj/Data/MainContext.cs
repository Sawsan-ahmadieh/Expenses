using System;
using System.Collections.Generic;
using System.Text;
using incomeproj.Models;
using Microsoft.EntityFrameworkCore;

namespace incomeproj.Data
{
    class MainContext:DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Income;Trusted_Connection=True");
        }
        
        public DbSet<Income> Income { get; set; }
        public DbSet<Expenditure> Expenditure { get; set; }

    }
}
