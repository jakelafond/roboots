using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using roboots.Models;
using System.IO;
using Newtonsoft.Json;
using roboots.Services;

namespace roboots.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var robotList = RobotServices.Builder();

            return View(robotList);
        }
        [Route("/user/{ID}")]
        public IActionResult UserID(int id)
        {
            var robotList = RobotServices.Builder();
            return View(robotList[id -1]);

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
