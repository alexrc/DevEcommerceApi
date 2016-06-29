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

        public IEnumerable<Developer> GetDevelopers(int page, int perPage)
        {
            string url = githubAPIbaseUrl + "users";

            url += page > 0 ? "?page=" + page.ToString() : perPage > 0 ? "?per_page=" + perPage.ToString() : string.Empty;
            url += page > 0 && perPage > 0 ? "&per_page=" + perPage.ToString() : string.Empty;

            jsonResponse = GetResponse(url);
            
            return JsonConvert.DeserializeObject<IEnumerable<Developer>>(jsonResponse);
        }

        public Developer GetDeveloperById(string Id)
        {
            jsonResponse = GetResponse(githubAPIbaseUrl + "user/" + Id);
            
            return JsonConvert.DeserializeObject<Developer>(jsonResponse);
        }

        public Developer GetDeveloperByLogin(string devLogin)
        {
            jsonResponse = GetResponse(githubAPIbaseUrl + "users/" + devLogin);

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