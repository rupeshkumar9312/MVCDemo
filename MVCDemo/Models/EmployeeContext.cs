using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCDemo.Models
{
    /*
     * 1) Install Entity Framework
     * 2) Add EmployeeContext.cs class to Model folder
     * 3) Add a connection string to web.config file, in root directory
     * 4) Make changes to Employee Controller to 'details' method.
     */
    public class EmployeeContext : DbContext    // to establish connection to our database 
    {
        public DbSet<Employee> Employees { get; set; }
    }
}