using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevEcommerceAPI.GithubApi;
using DevEcommerceAPI.DataContracts;

namespace DevEcommerceAPI
{
    public class DevEcommerceService : IDevEcommerceService
    {
        public Developer GetDeveloperById(string id)
        {
            return new GithubAPIClient().GetDeveloperById(id);
        }

        public IEnumerable<Developer> GetDevelopers()
        {
            return new GithubAPIClient().GetDevelopers();
        }

        public string CalculateDevPrice(string devLogin)
        {
            GithubAPIClient githubAPIClient = new GithubAPIClient();

            Developer user = githubAPIClient.GetDeveloperById(devLogin);

            int followersCount = int.Parse(user.followers);
            int repositoriesCount = int.Parse(user.public_repos);


            return null;
        }
    }
}