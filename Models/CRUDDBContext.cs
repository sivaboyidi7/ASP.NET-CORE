using Microsoft.EntityFrameworkCore;
using System;

namespace ASP.NETCore.Models
{
    public class CRUDDBContext : DbContext
    {
        public CRUDDBContext(DbContextOptions<CRUDDBContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
