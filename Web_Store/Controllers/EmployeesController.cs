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
            return View(AuxiliaryData.Employees);
        }
        public IActionResult Details(int id) {
            var employee = AuxiliaryData.Employees.FirstOrDefault(e => e.Id == id);
            if (employee is not null)
                return View(employee);
            else
                return NotFound();
        }
    }
}
