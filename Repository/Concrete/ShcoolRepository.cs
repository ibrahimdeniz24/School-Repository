using _21_MVC_RepositorySchool.Models;
using _21_MVC_RepositorySchool.Models.Context;
using _21_MVC_RepositorySchool.Repository.Abstract;

namespace _21_MVC_RepositorySchool.Repository.Concrete
{
    public class ShcoolRepository : BaseReposirtory<School>, IShcoolRepository
    {
        private readonly AppDbContext _appDbContext;

        public ShcoolRepository(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }

        public IQueryable<School> Schools => _appDbContext.Schools;

        public void Add(School entity)
        {
            _appDbContext.Schools.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Delete(School entity)
        {
            _appDbContext.Remove(entity);
            _appDbContext.SaveChanges();

        }

        public School GetById(int id)
        {
            return _appDbContext.Schools.Find(id);


        }

        public void Update(School entity)
        {
            _appDbContext.Schools.Update(entity);
            _appDbContext.SaveChanges();

        }
    }
}
