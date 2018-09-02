using DAO.services;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BLL
{
    public class RepositoriosNegocio
    {
        #region ObterRepositorios
        public string ObterRepositoriosAsync()
        {
            var service = new GithubServices();

            return service.GetRepositories();


        }
        #endregion
    }
}
