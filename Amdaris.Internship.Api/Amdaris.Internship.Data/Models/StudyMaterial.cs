namespace Amdaris.Internship.Data.Models
{
    public class StudyMaterial : BaseEntity
    {
        public Lecture Lecture { get; set; }

        public Guid? LectureId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string FileUrl { get; set; }
    }
}
