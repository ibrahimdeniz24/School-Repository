using _21_MVC_RepositorySchool.Models.ViewModels;
using _21_MVC_RepositorySchool.Models;
using _21_MVC_RepositorySchool.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _21_MVC_RepositorySchool.Models.Context;

namespace _21_MVC_RepositorySchool.Controllers
{
    public class ClassRoomController : Controller
    {
        private readonly IClassRoomRepository _classroomRepository;
        private readonly IShcoolRepository _shcoolRepository;

        public ClassRoomController(IClassRoomRepository classroomRepository, IShcoolRepository shcoolRepository)
        {
            _classroomRepository = classroomRepository;
            _shcoolRepository = shcoolRepository;
        }

        public IActionResult Index()
        {
            List<ClassRoom> classRooms = _classroomRepository.ClassRooms.ToList();
            return View(classRooms);
        }

        public IActionResult Delete(ClassRoom classRoom)
        {
            _classroomRepository.Delete(classRoom);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            ClassRoom clasRoom = _classroomRepository.GetById(id);
            return View(clasRoom);
        }

        public IActionResult Create()
        {
            ViewBag.Schools = _shcoolRepository.Schools;
            return View();
        }

        [HttpPost]
        public IActionResult Create(ClassRoom classRoom)
        {
            _classroomRepository.Add(classRoom);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {

            EditClassRoomVM classRoomVM = new EditClassRoomVM()
            {
                ClassRoom = _classroomRepository.GetById(id),
                ClassRooms = _classroomRepository.ClassRooms,
            };

            return View(classRoomVM);
        }
        [HttpPost]
        public IActionResult Edit(ClassRoom classRoom)
        {
            _classroomRepository.Update(classRoom);
            return RedirectToAction("Index");

        }
    }
}
