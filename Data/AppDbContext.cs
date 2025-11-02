using CarWash.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CarWash.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Package> Packages { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=db_vb2_car_wash;Username=postgres;Password=miftahulrizky");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Package>()
                .HasMany(p => p.Transactions)
                .WithOne(t => t.Package)
                .HasForeignKey(t => t.PackageId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
