using CodeFirst.Library.Context;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Library
{
    public static class Common
    {        
        public static void CreateDatabase(string dbName)
        {
            var ConnectionStringTemplate = ConfigurationManager.AppSettings["ConnectionStringFormat"].ToString();
            CompanyContext context = new CompanyContext(string.Format(ConnectionStringTemplate,dbName));
            context.Database.CreateIfNotExists();
        }

        public static void CreateAdminDatabase()
        {
            AdminContext context = new AdminContext();
            context.Database.CreateIfNotExists();
        }
    }
}
