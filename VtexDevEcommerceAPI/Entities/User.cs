using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace VtexDevEcommerceAPI.Entities
{
    public class User
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
    }
}