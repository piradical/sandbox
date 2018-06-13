using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCoreSandbox.Models;

namespace MyCoreSandbox.Controllers
{
    public class HomeController : Controller
    {

        MyDbContext _context;

        public HomeController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var set1 = _context.Vessels;

            var set2 = _context.Set<Vessel>();

            

            set1.Add(new Vessel
            {
                Name = "Boaty McBoatface",
                Description = "This is a test!"
            });


            return View(set1);

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
