using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using WebDangKyMonHoc.Models;
using System.Linq;
using System.Collections.Generic;

namespace WebDangKyMonHoc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Entities _db = new Entities();
        IList<Student> studentList = new List<Student>() {
                    new Student(){ StudentID=1, StudentName="Steve", Age = 21 },
                    new Student(){ StudentID=2, StudentName="Bill", Age = 25 },
                    new Student(){ StudentID=3, StudentName="Ram", Age = 20 },
                    new Student(){ StudentID=4, StudentName="Ron", Age = 31 },
                    new Student(){ StudentID=5, StudentName="Rob", Age = 19 }
                };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var data = (from s in _db.Students select s).ToList();
            ViewBag.users = data;
            ViewBag.title = "MVC5 - Hello World";
            //ViewBag.TotalStudents = studentList.Count();
            //ViewBag.users = studentList;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
