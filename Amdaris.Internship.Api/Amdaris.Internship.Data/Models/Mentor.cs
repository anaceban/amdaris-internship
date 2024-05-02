namespace Amdaris.Internship.Data.Models
{
    public class Mentor : BaseEntity
    {
        public User User { get; set; }

        public string Position { get; set; }

        public List<Lecture> Lectures { get; set; }
    }
}
