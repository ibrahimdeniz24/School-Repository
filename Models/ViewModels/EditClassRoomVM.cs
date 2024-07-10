namespace _21_MVC_RepositorySchool.Models.ViewModels
{
    public class EditClassRoomVM
    {
        public ClassRoom ClassRoom { get; set; }

        public IQueryable<ClassRoom> ClassRooms { get; set; }
    }
}
