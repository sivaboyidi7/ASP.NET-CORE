using ASP.NETCore.Models;
using System.Collections.Generic;

namespace ASP.NETCore.Utils
{
    public interface iCRUDRepository
    {
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
        Employee GetEmployeeOnId(int id);
        IEnumerable<Employee> GetAllEmployees();
    }
}
