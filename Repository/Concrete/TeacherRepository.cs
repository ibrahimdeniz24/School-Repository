using _21_MVC_RepositorySchool.Models;
using _21_MVC_RepositorySchool.Models.Context;
using _21_MVC_RepositorySchool.Repository.Abstract;

namespace _21_MVC_RepositorySchool.Repository.Concrete
{
    public class TeacherRepository : BaseReposirtory<Teacher>, ITeacherRepository
    {
        private readonly AppDbContext _appDbContext;
        public TeacherRepository(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }

        
        public IQueryable<Teacher> Teachers => _appDbContext.Teachers;


        public void Add(Teacher entity)
        {
            _appDbContext.Teachers.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Delete(Teacher entity)
        {
            _appDbContext.Teachers.Remove(entity);
            _appDbContext.SaveChanges();
        }

        public bool Delete(int id)
        {
            _appDbContext.Teachers.Remove(GetById(id));
            return _appDbContext.SaveChanges() > 0;
        }

        public Teacher GetById(int id)
        {
            return _appDbContext.Teachers.Find(id);
        }

        public void Update(Teacher entity)
        {
            _appDbContext.Teachers.Update(entity);
            _appDbContext.SaveChanges();
        }
    }
}
