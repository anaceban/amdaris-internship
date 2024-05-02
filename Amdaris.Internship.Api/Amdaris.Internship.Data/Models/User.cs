namespace Amdaris.Internship.Data.Models
{
    public class User : BaseEntity
    {
        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Role> Roles { get; set; }
    }
}
