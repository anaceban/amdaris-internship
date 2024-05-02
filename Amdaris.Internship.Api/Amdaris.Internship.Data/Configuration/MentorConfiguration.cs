using System.Data.Entity.ModelConfiguration;

using Amdaris.Internship.Data.Models;

namespace Amdaris.Internship.Data.Configuration
{
    public class MentorConfiguration : EntityTypeConfiguration<Mentor>
    {
        public MentorConfiguration() 
        {
            this.HasRequired(p => p.User)
                .WithOptional()
                .WillCascadeOnDelete(false);
        }
    }
}
