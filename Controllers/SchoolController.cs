using _21_MVC_RepositorySchool.Models;
using _21_MVC_RepositorySchool.Models.ViewModels;
using _21_MVC_RepositorySchool.Repository.Abstract;
using _21_MVC_RepositorySchool.Repository.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace _21_MVC_RepositorySchool.Controllers
{
    public class SchoolController : Controller
    {

        private readonly IShcoolRepository _schoolRepository;

        public SchoolController(IShcoolRepository schoolRepository)
        {
            _schoolRepository = schoolRepository;
        }

        public IActionResult Index()
        {
            IList<School> schools = _schoolRepository.Schools.ToList();
            return View(schools);
        }

        public IActionResult Delete(School school)
        {
            _schoolRepository.Delete(school);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            School school = _schoolRepository.GetById(id);
            return View(school);
        }

        public IActionResult Create()
        {
            ViewBag.Schools = _schoolRepository.Schools.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(School school)
        {
            _schoolRepository.Add(school);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewData["Schools"] = _schoolRepository.Schools.ToList();

            EditSchoolVM schoolVm = new EditSchoolVM()
            {
                School = _schoolRepository.GetById(id),
                Schools = _schoolRepository.Schools,
            };

            return View(schoolVm);
        }
        [HttpPost]
        public IActionResult Edit(School school)
        {
            _schoolRepository.Update(school);
            return RedirectToAction("Index");

        }


    }
}
