using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using WebDangKyMonHoc.Models;
using WebDangKyMonHoc.DAL;
using System.Linq;
using System.Collections.Generic;

namespace WebDangKyMonHoc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private SchoolContext _db = new SchoolContext();
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var data = (from s in _db.Students select s).ToList();
            //ViewBag.users = data;
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
