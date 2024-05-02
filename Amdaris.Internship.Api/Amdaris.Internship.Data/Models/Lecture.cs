namespace Amdaris.Internship.Data.Models
{
    public class Lecture : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime? Date {  get; set; }

        public Mentor Mentor { get; set; }

        public Guid? MentorId { get; set; }

        public List<StudyMaterial> StudyMaterials { get; set; }

        public List<Grade> Grades { get; set; }
    }
}
