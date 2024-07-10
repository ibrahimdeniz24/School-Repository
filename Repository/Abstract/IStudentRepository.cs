using _21_MVC_RepositorySchool.Models;

namespace _21_MVC_RepositorySchool.Repository.Abstract
{
    public interface IStudentRepository:IRepository<Student> 
    {
        IQueryable<Student> Students { get; }

    }
}
