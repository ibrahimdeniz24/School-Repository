namespace _21_MVC_RepositorySchool.Models
{
    public class School
    {
        public int ID { get; set; }
        public string? SchoolName { get; set; }

        public string? Adress { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public DateTime? FoundedDate { get; set; }

        public ICollection<ClassRoom>? ClassRooms { get; set; }
    }
}
