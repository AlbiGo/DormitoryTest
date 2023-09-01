using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DBContext
{
    public class DormitoryDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Dormitory> Dormitories { get; set; }
        public DbSet<StudentDormitory> StudentDormitories { get; set; }

        public DormitoryDBContext()
        {
        }
        public DormitoryDBContext(DbContextOptions<DormitoryDBContext> options)
          : base(options)
        {   
        }
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=WINDOWS-4PGG12B; Initial Catalog=Dormitory;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity => {
                entity.HasKey(k => k.Id);
            });
            modelBuilder.Entity<Dormitory>(entity => {
                entity.HasKey(k => k.Id);
            });
            modelBuilder.Entity<StudentDormitory>(entity => {
                entity.HasKey(k => k.Id);
            });

        }
    }
}

