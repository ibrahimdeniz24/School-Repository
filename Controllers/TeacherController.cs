using _21_MVC_RepositorySchool.Models;
using _21_MVC_RepositorySchool.Models.ViewModels;
using _21_MVC_RepositorySchool.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace _21_MVC_RepositorySchool.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IClassRoomRepository _classRoomRepository;

        public TeacherController(ITeacherRepository teacherRepository, IClassRoomRepository classRoomRepository)
        {
            _teacherRepository = teacherRepository;
            _classRoomRepository = classRoomRepository;
        }

        public IActionResult Index()
        {
            List<Teacher> teachers = _teacherRepository.Teachers.ToList();
            return View(teachers);
        }

        public IActionResult Delete(Teacher teacher)
        {
            _teacherRepository.Delete(teacher);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Teacher teacher = _teacherRepository.GetById(id);
            return View(teacher);
        }

        public IActionResult Create()
        {
            ViewBag.ClasRoom = _classRoomRepository.ClassRooms;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            _teacherRepository.Add(teacher);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {

            EditTeacherVM teacherVM = new EditTeacherVM()
            {
                Teacher = _teacherRepository.GetById(id),
                Teachers = _teacherRepository.Teachers,
            };

            return View(teacherVM);
        }
        [HttpPost]
        public IActionResult Edit(Teacher teacher)
        {
            _teacherRepository.Update(teacher);
            return RedirectToAction("Index");

        }
    }
}
