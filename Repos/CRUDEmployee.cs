using ASP.NETCore.Models;
using ASP.NETCore.Utils;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCore.Repos
{
    public class CRUDEmployee : iCRUDRepository
    {
        private readonly CRUDDBContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public CRUDEmployee(CRUDDBContext context,IHostingEnvironment hostingEnvironment)
        {
            this._context = context;
            this._hostingEnvironment = hostingEnvironment;
        }
        public void CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = GetEmployeeOnId(id);
            if (employee != null)
            {
                _context.Remove(employee);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees;
        }

        public Employee GetEmployeeOnId(int id)
        {
            return _context.Employees.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateEmployee(Employee employee)
        {
            Employee existingEmployee = GetEmployeeOnId(employee.Id);
            if (existingEmployee != null)
            {
                _context.Employees.Update(new Employee()
                {
                    Department = employee.Department,
                    Email = employee.Email,
                    Name = employee.Name,
                    Picture = employee.Picture
                });
                _context.SaveChanges();
            }
        }
    }
}
