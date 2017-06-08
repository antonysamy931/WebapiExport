using CodeFirst.Library.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Library.Context
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(string connectionstring)
            : base(connectionstring)
        {
        }

        public DbSet<Tab> Tabs { get; set; }
    }
}
