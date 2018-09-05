using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAvonale.Models
{
    public class RepositorioModel
    {
        public Int64 total_count { get; set; }
        public Int64 id { get; set; }
        public string node_id { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public string html_url { get; set; }
        public string description { get; set; }
        public int watchers_count { get; set; }
        public string updated_at { get; set; }
        public string default_branch { get; set; }
        public int forks_count { get; set; }
        public string forks_url { get; set; }
        public string language { get; set; }

        public List<ContribuidorModel> contribuidores { get; set; }
    }

    public class ContribuidorModel
    {
        public string login { get; set; }
        public string avatar_url { get; set; }
        public int contributions { get; set; }
    }
}