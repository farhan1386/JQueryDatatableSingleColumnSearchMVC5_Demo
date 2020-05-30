using JQueryDatatableHideShowColumnsMvc_Demo.Models;
using System.Data.Entity;

namespace JQueryDatatableHideShowColumnsMvc_Demo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("EmployeeDB")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}