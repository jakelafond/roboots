using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using roboots.Models;
using System.IO;
using Newtonsoft.Json;

namespace roboots.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            JsonSerializer serializer = new JsonSerializer();

                using (var reader = new StreamReader(System.IO.File.Open("robots.json",FileMode.Open)))
                {
                    var vehicleInfo2 = JsonConvert.DeserializeObject<VehicleInfo>(file.ReadToEnd());
                    vehicleList.Add(vehicleInfo2);
                    totalOdometer += vehicleInfo2.Odometer;
                    tableHtml += string.Format($"{itemTemplate}",vehicleInfo2.VIN,vehicleInfo2.Odometer,vehicleInfo2.Consumption,vehicleInfo2.OdometerLastOilChange,vehicleInfo2.EngineSize);
                }
            return View();
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
