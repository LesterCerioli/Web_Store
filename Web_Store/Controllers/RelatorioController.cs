using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Store.Controllers
{
    public class RelatorioController : Controller
    {
        // GET: Relatorio
        public ActionResult Stockposition()
        {
            return View();
        }
        public ActionResult Ressup()
        {
            return View();
        }
    }
}