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
using DevEcommerceAPI.DataContracts;

namespace DevEcommerceAPI.GithubApi
{
    public class GithubAPIClient
    {
        HttpWebRequest req;
        string githubAPIbaseUrl = "https://api.github.com/";
        string jsonResponse;

        private void CreateRequest(string url)
        {
            req = (HttpWebRequest)WebRequest.Create(url);
            req.Headers[HttpRequestHeader.Authorization] = "Basic YWxleHJjOmFwdGl2YTEy";
            req.UserAgent = "VTex_Test";
        }

        public IEnumerable<Developer> GetDevelopers()
        {
            jsonResponse = GetResponse( githubAPIbaseUrl + "users");
            
            return JsonConvert.DeserializeObject<IEnumerable<Developer>>(jsonResponse);
        }

        public Developer GetDeveloperById(string Id)
        {
            jsonResponse = GetResponse(githubAPIbaseUrl + "user/" + Id);
            
            return JsonConvert.DeserializeObject<Developer>(jsonResponse);
        }

        public Developer GetDeveloperDetails(string devLogin)
        {
            jsonResponse = GetResponse(githubAPIbaseUrl + "user/" + devLogin);

            return JsonConvert.DeserializeObject<Developer>(jsonResponse);
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