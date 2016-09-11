using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCEntityFrameworkTest4.Data.Models;

namespace MVCEntityFrameworkTest4.Data.DBContext
{
    public class MyDatabaseContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        
    }
}