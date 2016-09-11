using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEntityFrameworkTest4.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; } 
        public string City { get; set; }
        public string Country { get; set; }
    }
}