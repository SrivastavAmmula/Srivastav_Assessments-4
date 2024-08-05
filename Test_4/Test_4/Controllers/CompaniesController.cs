using Microsoft.AspNetCore.Mvc;
using Test_4.Entities;

namespace Test_4.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly Assessment4Context _context;
        public CompaniesController()
        {
            _context = new Assessment4Context();
        }
        [HttpGet]
        public IActionResult Index()
        {
            var company = _context.Companies;
            return View(company);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Company company)
        {
            if (ModelState.IsValid)
            {
                _context.Companies.Add(company);
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
            var company = _context.Companies.Single(s=>s.CompanyId==id);
            return View(company);
        }
    }
}