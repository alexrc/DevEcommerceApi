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
        public Developer GetDeveloperByLogin(string login)
        {
            return new GithubAPIClient().GetDeveloperByLogin(login);
        }

        public IEnumerable<Developer> GetDevelopers(int page, int perPage)
        {
            return new GithubAPIClient().GetDevelopers(page,perPage);
        }

        public string CalculateDevPrice(string devLogin)
        {
            GithubAPIClient githubAPIClient = new GithubAPIClient();

            Developer user = githubAPIClient.GetDeveloperById(devLogin);

            int followersCount = int.Parse(user.followers);
            int repositoriesCount = int.Parse(user.public_repos);


            return (followersCount + repositoriesCount).ToString();
        }
    }
}