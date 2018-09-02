using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DAO.services
{
    public class GithubServices
    {
        private static readonly HttpClient client = new HttpClient();

        //  public string GetRepoUserAsync(string user = "RafasTaares")

        //  







        public string GetRepositories(string user = "RafasTavares")
        {


            string url = @"https://api.github.com/users/" + user + "/repos";
            string json = "";

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.UserAgent = "TestApp";
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            StreamReader reader = new StreamReader(response.GetResponseStream());
            return json = reader.ReadToEnd();
        }
    }

}