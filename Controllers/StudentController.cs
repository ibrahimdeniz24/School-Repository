using _21_MVC_RepositorySchool.Models.ViewModels;
using _21_MVC_RepositorySchool.Models;
using _21_MVC_RepositorySchool.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace _21_MVC_RepositorySchool.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IClassRoomRepository _classRoomRepository;

        public StudentController(IStudentRepository studentRepository, IClassRoomRepository classRoomRepository)
        {
            _studentRepository = studentRepository;
            _classRoomRepository = classRoomRepository;
        }

        public IActionResult Index()
        {
            List<Student> students = _studentRepository.Students.ToList();
            return View(students);
        }

        public IActionResult Delete(Student student)
        {
            _studentRepository.Delete(student);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Student student = _studentRepository.GetById(id);
            return View(student);
        }

        public IActionResult Create()
        {
            ViewBag.ClassRoom = _classRoomRepository.ClassRooms;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _studentRepository.Add(student);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {


            EditStudentVM studentVM = new EditStudentVM()
            {
                Student = _studentRepository.GetById(id),
                Students = _studentRepository.Students,
            };

            return View(studentVM);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _studentRepository.Update(student);
            return RedirectToAction("Index");

        }
    }
}
