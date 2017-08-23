using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNet.Pruebas.Controllers
{
    public class SoccerController : Controller
    {
        // GET: Soccer
        public ActionResult Index()
        {
            return View();
        }
    }
}