using Microsoft.AspNetCore.Mvc;
using Test_4.Entities;

namespace Test_4.Controllers
{
    public class StudentController : Controller
    {
        private readonly Assessment4Context _context;
        public StudentController()
        {
            _context = new Assessment4Context();
        }
        [HttpGet]
        public IActionResult Index()
        {
            var student = _context.Students;
            return View(student);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var student = _context.Students.Single(s=>s.StudentId==id);
            return View(student);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _context.Students.Single(s=>s.StudentId==id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Update(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = _context.Students.Single(s => s.StudentId == id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Delete(Student student)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
