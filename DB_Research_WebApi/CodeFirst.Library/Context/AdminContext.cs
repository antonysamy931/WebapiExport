using CodeFirst.Library.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Library.Context
{
    public class AdminContext : DbContext
    {
        public AdminContext()
            : base("name=Admin.Connection")
        {
        }
        public DbSet<Company> Companies { get; set; }
    }
}
