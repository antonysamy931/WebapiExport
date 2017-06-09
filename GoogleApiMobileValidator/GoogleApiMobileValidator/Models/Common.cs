using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace GoogleApiMobileValidator.Models
{
    public static class Common
    {
        public static ResponseModel GetResponse(string ValidateUrl)
        {
            var ApiUrl = ConfigurationManager.AppSettings["Google.Api"].ToString();
            ApiUrl = string.Format(ApiUrl, ValidateUrl);
            ResponseModel model = new ResponseModel();
            HttpWebRequest GETRequest = (HttpWebRequest)WebRequest.Create(ApiUrl);
            //Method type
            GETRequest.Method = "GET";
            GETRequest.ContentType = "application/json";
            GETRequest.Accept = "application/json";
            GETRequest.MediaType = "application/json";
            GETRequest.KeepAlive = false;

            try
            {
                // Return the response.                
                HttpWebResponse response = GETRequest.GetResponse() as HttpWebResponse;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseStream = response.GetResponseStream();
                    StreamReader streamReader = new StreamReader(responseStream);
                    string rawResponse = streamReader.ReadToEnd();
                    model = JsonConvert.DeserializeObject<ResponseModel>(rawResponse);
                }
            }
            catch (WebException e)
            {
                throw e;                
            }
            return model;
        }
    }
}