using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Amdaris.Internship.Data.Models;

namespace Amdaris.Internship.Data.Configuration
{
    public class LectureConfiguration : EntityTypeConfiguration<Lecture>
    {
        public LectureConfiguration() 
        {
            this.Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasOptional(x => x.Mentor)
                .WithMany(x => x.Lectures)
                .HasForeignKey(x => x.MentorId)
                .WillCascadeOnDelete(false);
        }
    }
}
