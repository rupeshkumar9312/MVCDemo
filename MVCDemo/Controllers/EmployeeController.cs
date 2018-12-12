
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {

        //Generating HyperLinks
        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
           // Employee employee = employeeContext.Employees.Single();
            List<Employee> list = employeeContext.Employees.ToList<Employee>();
            return View(list);
        }

        // GET: Employee
        public ActionResult Details(int id)
        {

            EmployeeContext employeeContext = new EmployeeContext();
           // Employee emp1 = employeeContext.Employees.SelectMany(emp => emp.id);

            Employee employee = employeeContext.Employees.Single(emp => emp.id == id);

            //Employee employee = new Employee
            //{
            //    EmpId = 101,
            //    EmpName = "Rupesh",
            //    EmpCity = "Agra"
            //};  
            return View(employee);
        }
    }
}