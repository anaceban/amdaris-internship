using Amdaris.Internship.Data.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Amdaris.Internship.Data.Context
{
    public class InternshipDbContext : DbContext
    {
        private string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = AmdarisInternship; Integrated Security = True;";
        public virtual DbSet<Mentor> Mentors { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Lecture> Lectures { get; set; }
        public virtual DbSet<StudyMaterial> StudyMaterials { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public InternshipDbContext(DbContextOptions<InternshipDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(InternshipDbContext).Assembly);
        }
    }
}
