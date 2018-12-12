using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
    }
}