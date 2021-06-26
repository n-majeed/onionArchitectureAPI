using Microsoft.EntityFrameworkCore;
using System;
using DomainLayer.EntityMapper;
using DomainLayer.Models;

namespace RepositoryLayer
{
    public partial class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
