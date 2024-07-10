namespace _21_MVC_RepositorySchool.Models.ViewModels
{
    public class EditStudentVM
    {
        public Student Student { get; set; }

        public IQueryable<Student> Students { get; set; }
    }
}
