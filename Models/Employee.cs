using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASP.NETCore.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide name!")]
        [MaxLength(length: 50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please provide Email!")]
        public string Email { get; set; }
        public string Department { get; set; }
        public string Picture { get; set; }
    }
}
