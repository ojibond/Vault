using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vault.Entities.DbSet;

namespace Vault.Dataservice.Data
{
    public class AppDbContext : DbContext
    {
        //Defined the Db entities
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Specified the relationship between the entities
            modelBuilder.Entity<Employee>().HasMany(e => e.Customers)
                .WithOne(c => c.Employees).IsRequired()
                .HasForeignKey(c => c.EmployeeId);
        }

    }
}
