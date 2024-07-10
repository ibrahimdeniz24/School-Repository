using _21_MVC_RepositorySchool.Models;
using _21_MVC_RepositorySchool.Models.Context;
using _21_MVC_RepositorySchool.Repository.Abstract;

namespace _21_MVC_RepositorySchool.Repository.Concrete
{
    public class StudentRepository : BaseReposirtory<Student>, IStudentRepository
    {
        private readonly AppDbContext _appDbContext;

        public StudentRepository(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }

        public IQueryable<Student> Students => _appDbContext.Students;

        public void Add(Student entity)
        {
            _appDbContext.Students.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Delete(Student entity)
        {
            _appDbContext.Remove(entity);
            _appDbContext.SaveChanges();
        }

        public IQueryable<Student> GetAll()
        {
            _appDbContext.Students.ToList();
            return _appDbContext.Students;
        }

        public Student GetById(int id)
        {
            return _appDbContext.Students.Find(id);
        }

        public void Update(Student entity)
        {
            _appDbContext.Students.Update(entity);
            _appDbContext.SaveChanges();

        }
    }
}
