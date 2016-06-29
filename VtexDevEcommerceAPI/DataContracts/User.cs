﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DevEcommerceAPI.DataContracts
{
    public class Developer
    {
        public string login { get; set; }

        public string id { get; set; }

        public string avatar_url { get; set; }

        public string gravatar_id { get; set; }

        public string url { get; set; }

        public string html_url { get; set; }

        public string followers_url { get; set; }

        public string following_url { get; set; }

        public string gists_url { get; set; }

        public string starred_url { get; set; }

        public string subscriptions_url { get; set; }

        public string organizations_url { get; set; }

        public string repos_url { get; set; }

        public string events_url { get; set; }

        public string received_events_url { get; set; }

        public string type { get; set; }

        public bool site_admin { get; set; }

        public string name { get; set; }

        public string company { get; set; }

        public string blog { get; set; }

        public string location { get; set; }

        public string email { get; set; }

        public string hireable { get; set; }

        public string bio { get; set; }

        public string public_repos { get; set; }

        public string followers { get; set; }

        public string following { get; set; }

        public string created_at { get; set; }

        public string updated_at { get; set; }
        
    }
}