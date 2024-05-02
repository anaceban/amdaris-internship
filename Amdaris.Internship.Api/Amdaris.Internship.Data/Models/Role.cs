namespace Amdaris.Internship.Data.Models
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }

        public List<User> Users { get; set; }
    }
}
