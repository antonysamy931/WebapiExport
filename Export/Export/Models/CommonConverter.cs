using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;

namespace Export.Models
{
    public static class ExportConverter
    {
        public static DataTable ToDataTable<T>(this List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        public static byte[] ToCsv(this DataTable dtDataTable)
        {
            StringBuilder CsvFile = new StringBuilder();
            //Headers  
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                CsvFile.Append(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    CsvFile.Append(",");
                }
            }
            CsvFile.Append("\n");

            //Content
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            CsvFile.Append(value);
                        }
                        else
                        {
                            CsvFile.Append(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        CsvFile.Append(",");
                    }
                }
                CsvFile.Append("\n");
            } 
            return Encoding.ASCII.GetBytes(CsvFile.ToString());
        }

        public static byte[] ToExcel(this DataTable dtDataTable)
        {
            StringBuilder ExcelFile = new StringBuilder();
            ExcelFile.Append("<table>");
            //Headers  
            ExcelFile.Append("<tr>");
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                ExcelFile.AppendFormat("<td>{0}</td>", dtDataTable.Columns[i]);                
            }
            ExcelFile.Append("</tr>");

            //Content
            foreach (DataRow dr in dtDataTable.Rows)
            {
                ExcelFile.Append("<tr>");
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        ExcelFile.AppendFormat("<td>{0}</td>", value);                        
                    }
                }
                ExcelFile.Append("</tr>");
            }
            ExcelFile.Append("</table>");
            return Encoding.ASCII.GetBytes(ExcelFile.ToString());
        }
    }
}