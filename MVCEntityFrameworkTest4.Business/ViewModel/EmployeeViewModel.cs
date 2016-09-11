using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEntityFrameworkTest4.Business.ViewModel
{
    public class EmployeeViewModel
    {
        public int EmployeeID { get; set; }
        [Column("EmployeeName")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
