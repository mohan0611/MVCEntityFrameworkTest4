using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCEntityFrameworkTest4.Business.ViewModel;
using MVCEntityFrameworkTest4.Data.DBContext;
using MVCEntityFrameworkTest4.Data.Models;
using AutoMapper;

namespace MVCEntityFrameworkTest4.Business.Business
{
    public class EmployeeBL
    {
        private MyDatabaseContext db = new MyDatabaseContext();

        public List<EmployeeViewModel> GetEmployeeList()
        {
            List<EmployeeViewModel> objEmployeeViewModel = new List<EmployeeViewModel>();
            List<Employee> objEmployee = db.Employees.ToList();

            //Use auto mapper to copy the data from one  object to another
            Mapper.Initialize(cfg => cfg.CreateMap<Employee, EmployeeViewModel>());

            foreach(Employee objEmpDL in objEmployee)
            {
                EmployeeViewModel dto = Mapper.Map<EmployeeViewModel>(objEmpDL);
                objEmployeeViewModel.Add(dto);
            }
            
            return objEmployeeViewModel;

        }
    }
}
