using _21_MVC_RepositorySchool.Models;

namespace _21_MVC_RepositorySchool.Repository.Abstract
{
    public interface IClassRoomRepository :IRepository<ClassRoom>
    {
        IQueryable<ClassRoom> ClassRooms { get; }
    }
}
