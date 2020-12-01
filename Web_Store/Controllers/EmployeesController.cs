using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Store.Data;

namespace Web_Store.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View(AuxiliaryData._Employees);
        }
    }
}
