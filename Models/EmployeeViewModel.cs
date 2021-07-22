using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCore.Models
{
    public enum Departments
    {
        IT,
        HR,
        BPO,
        Chemistry,
        None
    }
    public class EmployeeViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public IEnumerable<IFormFile> Picture { get; set; }
    }
}
