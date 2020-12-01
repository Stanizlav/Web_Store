using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Store.Data;
using Web_Store.Models;

namespace Web_Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _Configuration;
            

        public HomeController(IConfiguration Configuration) => _Configuration = Configuration;
        public IActionResult Index()
        {
            return View();
            //return Content("First Action");
        }

        public IActionResult SecondAction() {
            return Content(_Configuration["ControllerText"]);
        }

        public IActionResult Employees() {
            return View(AuxiliaryData._Employees);
        }
    }
}
