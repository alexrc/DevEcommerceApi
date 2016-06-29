using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Collections;
using VtexDevEcommerceAPI.Entities;

namespace VtexDevEcommerceAPI.GithubApi
{
    public class GithubAPIClient
    {
        HttpWebRequest req;

        private void CreateRequest(string url)
        {
            req = (HttpWebRequest)WebRequest.Create(url);
            req.Headers[HttpRequestHeader.Authorization] = "Basic YWxleHJjOmFwdGl2YTEy";
            req.UserAgent = "VTex_Test";
        }

        public IEnumerable<User> GetAllUsers()
        {
            CreateRequest("https://api.github.com/users");
            string jsonResponse;
            try
            {
                using (StreamReader responseReader = new StreamReader(req.GetResponse().GetResponseStream()))
                    jsonResponse = responseReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            
            return JsonConvert.DeserializeObject<IEnumerable<User>>(jsonResponse);
        }
    }
}