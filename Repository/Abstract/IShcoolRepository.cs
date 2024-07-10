using _21_MVC_RepositorySchool.Models;

namespace _21_MVC_RepositorySchool.Repository.Abstract
{
    public interface IShcoolRepository : IRepository<School>
    {
        IQueryable<School> Schools { get; }
    }
}
