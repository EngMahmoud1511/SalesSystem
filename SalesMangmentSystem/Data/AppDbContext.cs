using Microsoft.EntityFrameworkCore;
using SalesMangmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.Data
{
    public class AppDbContext:DbContext
    {
        private readonly AppContextFactory Factory=new AppContextFactory();
        public AppDbContext( DbContextOptions<AppDbContext> options):base(options) 
        {
            
        }
        internal virtual DbSet<Item> Items { get; set; }
        internal virtual DbSet<Customer> Customers { get; set; }
        internal virtual DbSet<Category> Categories { get; set; }
        internal virtual DbSet<Sales> Sales { get; set; }
        internal virtual DbSet<Employee> Employees { get; set; }
        internal virtual DbSet<Orders> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer(Factory.Connection);
           
        }
    }
}
