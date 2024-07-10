using _21_MVC_RepositorySchool.Models;

namespace _21_MVC_RepositorySchool.Repository.Abstract
{
    public interface ITeacherRepository:IRepository<Teacher>
    {
        IQueryable<Teacher> Teachers { get; }
    }
}
