using BLL;
using Newtonsoft.Json;
using ProjectAvonale.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjectAvonale.Controllers
{
    public class RepositoriosController : Controller
    {

        // GET: Repositorios
        public ActionResult Index()
        {
            try
            {
                IEnumerable<RepositorioModel> repositoriosList;
                var json = new RepositoriosNegocio().ObterRepositoriosAsync();

                repositoriosList = JsonConvert.DeserializeObject<List<RepositorioModel>>(json);

                ViewBag.Repositories = repositoriosList;
            }
            catch (Exception ex) { }
            return View();
        }

    }
}