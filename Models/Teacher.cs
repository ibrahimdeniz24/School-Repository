using System.ComponentModel.DataAnnotations.Schema;

namespace _21_MVC_RepositorySchool.Models
{
    public class Teacher
    {
        public int ID { get; set; }
        public string?   FirstName  { get; set; }

        public string? LastName { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? Gender { get; set; }

        public ClassRoom? ClassRoom { get; set; }


    }
}
