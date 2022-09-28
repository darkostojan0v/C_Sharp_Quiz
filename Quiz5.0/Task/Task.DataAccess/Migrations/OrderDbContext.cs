using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Domain.Models;

namespace Task.DataAccess.Migrations
{
    public class OrderDbContext : DbContext
    {

        public OrderDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .Property(x => x.Text)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Order>()
                .Property(x => x.Priority)
                .IsRequired();
        }

    }
}
