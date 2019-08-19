using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExemploDDD.ApplicationServices;
using ExemploDDD.Domain;
using ExemploDDD.Repository;

namespace EmpresaDDD.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        // Lista de Cliente
        public ActionResult Index()
        {
            var cliRepo = new ClienteRepository();
            var cliApp = new ClienteApp(cliRepo);

            var lista = cliApp.Listar();


            return View(lista);
        }
    }
}