using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Store.Models;

namespace Web_Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _Configuration;

        private static readonly List<Employee> _Employees = new()
        {
            new Employee { Id = 1, FirstName = "Тихон", LastName = "Вашков", Patronymic = "Фёдорович", Age = 24 },
            new Employee { Id = 2, FirstName = "Аркадий", LastName = "Чинилов", Patronymic = "Михайлович", Age = 27 },
            new Employee { Id = 3, FirstName = "Денис", LastName = "Ламов", Patronymic = "Степанович", Age = 26 }
        };

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
            return View(model:_Employees);
        }
    }
}
