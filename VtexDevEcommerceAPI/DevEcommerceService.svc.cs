using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VtexDevEcommerceAPI.Entities;
using VtexDevEcommerceAPI.GithubApi;

namespace VtexDevEcommerceAPI
{
    public class DevEcommerceService : IDevEcommerceService
    {
        public User GetUser(string id)
        {
            return new GithubAPIClient().GetUser(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return new GithubAPIClient().GetAllUsers();
        }
    }
}