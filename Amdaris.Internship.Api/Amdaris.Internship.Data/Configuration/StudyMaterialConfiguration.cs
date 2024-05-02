using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Amdaris.Internship.Data.Models;

namespace Amdaris.Internship.Data.Configuration
{
    public class StudyMaterialConfiguration : EntityTypeConfiguration<StudyMaterial>
    {
        public StudyMaterialConfiguration() 
        {
            this.Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasOptional(x => x.Lecture)
                .WithMany(x => x.StudyMaterials)
                .HasForeignKey(x => x.LectureId)
                .WillCascadeOnDelete(false);
        }
    }
}
