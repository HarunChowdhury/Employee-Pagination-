using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace Paging01.Models
{
    public class SampleDBContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}