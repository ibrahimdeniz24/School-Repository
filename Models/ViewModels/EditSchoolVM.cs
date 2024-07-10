namespace _21_MVC_RepositorySchool.Models.ViewModels
{
    public class EditSchoolVM
    {
        public School School { get; set; }

        public IQueryable<School> Schools { get; set; }
    }
}
