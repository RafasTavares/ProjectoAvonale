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
    }

}