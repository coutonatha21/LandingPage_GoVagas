using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMvcRazorCSharp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.QuemSomos = "QUEM SOMOS";
            ViewBag.Missao = "MISSÃO";
            ViewBag.Visao = "VISÃO";
            ViewBag.Valores = "VALORES";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contato";

            return View();
        }
    }
}