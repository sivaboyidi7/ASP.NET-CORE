using ASP.NETCore.Models;
using ASP.NETCore.Repos;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCore.Controllers
{
    public class CRUDController : Controller
    {
        private readonly CRUDDBContext cRUDDBContext;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;
        private readonly CRUDEmployee _cRUDEmployee;
        public CRUDController(CRUDDBContext cRUDDBContext, IHostingEnvironment hostingEnvironment, IConfiguration configuration)
        {
            this.cRUDDBContext = cRUDDBContext;
            this._hostingEnvironment = hostingEnvironment;
            this._configuration = configuration;
            _cRUDEmployee = new CRUDEmployee(this.cRUDDBContext, _hostingEnvironment);
        }

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _cRUDEmployee.CreateEmployee(employee);
            }
            return View("CreateEmployee");
        }

        [HttpGet]
        public ViewResult GetAllEmployees()
        {
            return View("EmployeesList", _cRUDEmployee.GetAllEmployees());
        }

        [HttpGet]
        public ViewResult EditEmployee(int id)
        {
            return View("CreateEmployee", _cRUDEmployee.GetEmployeeOnId(id));
        }

        [HttpGet]
        public ViewResult DeleteEmployee(int id)
        {
            _cRUDEmployee.DeleteEmployee(id);
            return View("EmployeesList", _cRUDEmployee.GetAllEmployees());
        }

        [HttpPost]
        public ViewResult UpdateEmployee(Employee employee)
        {
            _cRUDEmployee.UpdateEmployee(employee);

            return View("EmployeesList", _cRUDEmployee.GetAllEmployees());
        }

    }
}
