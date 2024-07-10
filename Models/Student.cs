using System.ComponentModel.DataAnnotations.Schema;

namespace _21_MVC_RepositorySchool.Models
{
    public class Student
    {
        public int ID { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public int? StudentNo { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? StudentAdress { get; set; }

        public string? ParentPhoneNumber { get; set; }

        public ClassRoom? ClassRoom { get; set; }
    }
}
