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
        IClienteApp clienteApp;
        public ClienteController(IClienteApp clienteAppObj)
        {
            this.clienteApp = clienteAppObj;

        }


        // Lista de Cliente
        public ActionResult Index()
        {
            

            var lista = clienteApp.Listar();
            return View(lista);
        }
    }
}