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

        private string RealizaConsulta(string metodo)
        {
            string urlBase = "https://api.github.com/";


            HttpWebRequest request = WebRequest.Create(urlBase + metodo) as HttpWebRequest;
            request.UseDefaultCredentials = true;
            request.Proxy.Credentials = CredentialCache.DefaultCredentials;
            request.UserAgent = "AppGit";
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            StreamReader reader = new StreamReader(response.GetResponseStream());
            return reader.ReadToEnd();
        }

        #region ObterRepositorios
        public string ObterRepositorios(string user = "RafasTavares")
        {
            return RealizaConsulta("users/" + user + "/repos");
        }
        #endregion

        #region BuscarRepositorios
        public string BuscarRepositorios(string nomeRepositorio)
        {
            return RealizaConsulta("search/repositories?q=" + nomeRepositorio);
        }
        #endregion

        #region DetalharRepositorio
        public string DetalharRepositorio(string nomeRepositorio)
        {
            return RealizaConsulta("search/repositories?q=" + nomeRepositorio);
        }
        #endregion

        #region BuscarContribuidores
        public string BuscarContribuidores(string nomeRepositorio)
        {
            return RealizaConsulta("repos/" + nomeRepositorio + "/contributors");
        }
        #endregion


    }

}