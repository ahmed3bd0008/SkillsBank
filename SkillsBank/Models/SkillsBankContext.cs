using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1_SkillsBank.Models
{
    public class SkillsBankContext : DbContext
    {

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CrsSkills> CrsSkills { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<CrsLevel> CrsLevels { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CrsType> CrsTypes { get; set; }
        public virtual DbSet<CrsStatus> CrsStatus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SkillsBankDB;Trusted_Connection=True;MultipleActiveResultSets=True");

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* unique validation on column in course table */
            modelBuilder.Entity<Course>().HasIndex(c => c.CrsReferenceText).IsUnique();

            /* primary key for CrsSkills table */
            modelBuilder.Entity<CrsSkills>().HasKey(c => new { c.CrsFK, c.skillFK });

            base.OnModelCreating(modelBuilder);
        }
    }
}
