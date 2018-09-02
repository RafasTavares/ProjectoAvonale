using DAO.services;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BLL
{
    public class RepositoriosNegocio
    {
        #region ObterRepositorios
        public string ObterRepositorios()
        {
            return new GithubServices().ObterRepositorios();
        }
        #endregion

        #region BuscarRepositorios
        public string BuscarRepositorios(string nmRepositorio)
        {
            return new GithubServices().BuscarRepositorios(nmRepositorio);
        }
        #endregion
    }
}
