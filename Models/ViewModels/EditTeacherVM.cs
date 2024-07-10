namespace _21_MVC_RepositorySchool.Models.ViewModels
{
    public class EditTeacherVM
    {
        public Teacher Teacher { get; set; }

        public IQueryable<Teacher> Teachers { get; set; }
    }
}
