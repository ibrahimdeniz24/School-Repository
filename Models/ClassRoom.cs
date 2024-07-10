using System.ComponentModel.DataAnnotations.Schema;

namespace _21_MVC_RepositorySchool.Models
{
    public class ClassRoom
    {
        public int ID { get; set; }

        public string? Name { get; set; }
        public ICollection<Student>? Students { get; set; }
        public int? SchoolId { get; set; }
        public School? School { get; set; }
        public Teacher? Teacher { get; set; }
    }
}
