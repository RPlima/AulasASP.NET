using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula01MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // Métodos dentro de um Controller são chamados de Action
        public string Index()
        {
            return "<h1>Meu Jhonson!!<h1>";
        }

        public ActionResult PaginaUm()
        {

            return View();
        }
    }
}