using Chetu_App.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chetu_App.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeDbContext dbContext; 

        public EmployeeController(EmployeeDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Employee>
                emp = dbContext.Employee.ToList();
            return View(emp); 
        }
    }
}
