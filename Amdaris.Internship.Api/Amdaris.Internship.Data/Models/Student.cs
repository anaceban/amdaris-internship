namespace Amdaris.Internship.Data.Models
{
    public class Student : BaseEntity
    {
        public User User { get; set; }

        public string Education {  get; set; }

        public List<Grade> Grades { get; set; }
    }
}
