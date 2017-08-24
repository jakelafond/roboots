using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using roboots.Models;

namespace roboots.Services
{
    public class RobotServices
    {
        public static List<RobotModel> Builder()
        {
            var robotList = new List<RobotModel>();
            // JsonSerializer serializer = new JsonSerializer();

            using (var reader = new StreamReader(System.IO.File.Open("robots.json", FileMode.Open)))
            {
                var robot = JsonConvert.DeserializeObject<List<RobotModel>>(reader.ReadToEnd());
                return robot;   

            }
        }
    }

}