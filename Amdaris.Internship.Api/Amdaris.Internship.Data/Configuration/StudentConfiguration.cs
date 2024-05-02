using System.Data.Entity.ModelConfiguration;

using Amdaris.Internship.Data.Models;

namespace Amdaris.Internship.Data.Configuration
{
    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration() 
        {
            this.HasRequired(p => p.User)
                .WithOptional()
                .WillCascadeOnDelete(false);
        }
    }
}
