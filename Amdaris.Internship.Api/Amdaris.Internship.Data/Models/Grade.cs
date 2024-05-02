namespace Amdaris.Internship.Data.Models
{
    public class Grade : BaseEntity
    {
        public decimal? Score { get; set; }

        public string Comments { get; set; }

        public Student Student { get; set; }

        public Guid? StudentId { get; set; }

        public Lecture Lecture { get; set; }

        public Guid? LectureId { get; set; }
    }
}
