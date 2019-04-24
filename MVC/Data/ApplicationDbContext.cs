using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DegreeStatus> DegreeStatuses { get; set; }
        public DbSet<RequirementStatus> RequirementStatuses { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Requirement> Requirements { get; set; }
        public DbSet<DegreeRequirement> DegreeRequirements { get; set; }
        public DbSet<DegreePlanTermRequirement> DegreePlanTermRequirements { get; set; }
        public DbSet<DegreePlan> DegreePlans { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentTerm> StudentTerms { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DegreeStatus>().ToTable("DegreeStatus");
            modelBuilder.Entity<RequirementStatus>().ToTable("RequirementStatus");
            modelBuilder.Entity<Degree>().ToTable("Degree");

            modelBuilder.Entity<Requirement>().ToTable("Requirements");
            modelBuilder.Entity<DegreeRequirement>().ToTable("DegreeRequirement");
            modelBuilder.Entity<DegreePlanTermRequirement>().ToTable("DegreePlanTermRequirement");
            modelBuilder.Entity<DegreePlan>().ToTable("DegreePlan");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<StudentTerm>().ToTable("StudentTerm");
        }
    }
}
