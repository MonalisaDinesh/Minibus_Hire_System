using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Minibus_Hire_System.Interfaces;
using Minibus_Hire_System.web.Models;
using Minibus_Hire_System.web.Models.Home;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Minibus_Hire_System.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService userService;

        public HomeController(ILogger<HomeController> logger, IUserService _userService)
        {
            _logger = logger;
            userService = _userService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel _model)
        {
            if (!ModelState.IsValid)
                return View(_model);

            return View();
        }

        public IActionResult Vehicle()
        {
            IList<VehicleViewModel> model = new List<VehicleViewModel>();
            model.Add(new VehicleViewModel { Name = "Mona", ShortDescr = "Testing", imageName = "Minibus-Gallery-3.jpg" });
            model.Add(new VehicleViewModel { Name = "Mona", ShortDescr = "Testing", imageName = "Minibus-Gallery-3.jpg" });
            model.Add(new VehicleViewModel { Name = "Mona", ShortDescr = "Testing", imageName = "Minibus-Gallery-3.jpg" });
            model.Add(new VehicleViewModel { Name = "Mona", ShortDescr = "Testing", imageName = "Minibus-Gallery-3.jpg" });
            model.Add(new VehicleViewModel { Name = "Mona", ShortDescr = "Testing", imageName = "Minibus-Gallery-3.jpg" });
            model.Add(new VehicleViewModel { Name = "Mona", ShortDescr = "Testing", imageName = "Minibus-Gallery-3.jpg" });
            model.Add(new VehicleViewModel { Name = "Mona", ShortDescr = "Testing", imageName = "Minibus-Gallery-3.jpg" });
            model.Add(new VehicleViewModel { Name = "Mona", ShortDescr = "Testing", imageName = "Minibus-Gallery-3.jpg" });
            model.Add(new VehicleViewModel { Name = "Mona", ShortDescr = "Testing", imageName = "Minibus-Gallery-3.jpg" });
            model.Add(new VehicleViewModel { Name = "Mona", ShortDescr = "Testing", imageName = "Minibus-Gallery-3.jpg" });
            model.Add(new VehicleViewModel { Name = "Mona", ShortDescr = "Testing", imageName = "Minibus-Gallery-3.jpg" });
            model.Add(new VehicleViewModel { Name = "Mona", ShortDescr = "Testing", imageName = "Minibus-Gallery-3.jpg" });
            model.Add(new VehicleViewModel { Name = "Mona", ShortDescr = "Testing", imageName = "Minibus-Gallery-3.jpg" });
            return View(model.AsEnumerable());
        }


        public IActionResult Privacy()
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
