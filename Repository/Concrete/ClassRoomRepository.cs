using _21_MVC_RepositorySchool.Models;
using _21_MVC_RepositorySchool.Models.Context;
using _21_MVC_RepositorySchool.Repository.Abstract;

namespace _21_MVC_RepositorySchool.Repository.Concrete
{
    public class ClassRoomRepository : BaseReposirtory<ClassRoom>, IClassRoomRepository
    {
        private readonly AppDbContext _appDbContext;
        public ClassRoomRepository(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }

        public IQueryable<ClassRoom> ClassRooms => _appDbContext.ClassRooms;

        public void Add(ClassRoom entity)
        {
            _appDbContext.ClassRooms.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Delete(ClassRoom entity)
        {
            _appDbContext.ClassRooms.Remove(entity);
            _appDbContext.SaveChanges();
        }

        public ClassRoom GetById(int id)
        {
            return _appDbContext.ClassRooms.Find(id);

        }

        public void Update(ClassRoom entity)
        {
            _appDbContext.ClassRooms.Update(entity);

        }
    }
}
