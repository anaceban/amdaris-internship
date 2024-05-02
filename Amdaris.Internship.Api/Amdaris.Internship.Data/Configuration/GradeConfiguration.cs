using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Amdaris.Internship.Data.Models;

namespace Amdaris.Internship.Data.Configuration
{
    public class GradeConfiguration : EntityTypeConfiguration<Grade>
    {
        public GradeConfiguration() 
        {
            this.Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasOptional(x => x.Student)
                .WithMany(x => x.Grades)
                .HasForeignKey(x => x.StudentId)
                .WillCascadeOnDelete(false);

            this.HasOptional(x => x.Lecture)
                .WithMany(x => x.Grades)
                .HasForeignKey(x => x.LectureId)
                .WillCascadeOnDelete(false);
        }
    }
}
