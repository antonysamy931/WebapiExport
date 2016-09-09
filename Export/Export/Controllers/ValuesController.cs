using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using Export.Models;
using System.Data;

namespace Export.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Export(string type)
        {            
            var sb = new StringBuilder();
            HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);            
            DataTable table = books.ToDataTable<Book>();
            if (type == "csv")
            {
                result.Content = new ByteArrayContent(table.ToCsv());
            }
            else
            {
                result.Content = new ByteArrayContent(table.ToExcel());
            }
            result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            result.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment"); //attachment will force download
            result.Content.Headers.ContentDisposition.FileName = "RecordExport."+ type;

            return result;
        }

        List<Book> books = new List<Book>    
        {    
            new Book { Id = 1, Name = "A way to Galway", Author = "Tom Moore", Rating = 5 },   
            new Book { Id = 2, Name = "As fast as a Berner", Author = "Bob Nobody", Rating = 4 },   
            new Book { Id = 3, Name = "Singing Loud", Author = "Tim Mooney", Rating = 3 },  
            new Book { Id = 4, Name = "Lookup", Author = "Philip Jones", Rating = 2 },   
            new Book { Id = 5, Name = "Fighting Molly", Author = "Patrick Host", Rating = 1 },   
            new Book { Id = 6, Name = "Calling home", Author = "Oliver McNearney", Rating = 6 },   
        };
    }
}