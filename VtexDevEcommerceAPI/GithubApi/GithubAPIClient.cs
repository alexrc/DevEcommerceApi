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
        string url = "https://api.github.com/";

        private void CreateRequest(string url)
        {
            req = (HttpWebRequest)WebRequest.Create(url);
            req.Headers[HttpRequestHeader.Authorization] = "Basic YWxleHJjOmFwdGl2YTEy";
            req.UserAgent = "VTex_Test";
        }

        public IEnumerable<User> GetAllUsers()
        {
            string jsonResponse = GetResponse( url + "users");
            
            return JsonConvert.DeserializeObject<IEnumerable<User>>(jsonResponse);
        }


        public User GetUser(string Id)
        {
            string jsonResponse = GetResponse( url + "user/" + Id);
            
            return JsonConvert.DeserializeObject<User>(jsonResponse);
        }

        private string GetResponse(string url)
        {
            CreateRequest(url);

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
            return jsonResponse;
        }

    }
}