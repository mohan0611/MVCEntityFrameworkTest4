using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEntityFrameworkTest4.Data.Models
{
    [Table("tblEmployee")]
    public class Employee
    {
        public int EmployeeID { get; set; }
        [Column("EmployeeName")]
        public string Name { get; set; } 
        public string City { get; set; }
        public string Country { get; set; } 
    }
}