using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UcururAirline.Entities;

namespace UcururAirline.UI.Controllers
{
    public class HomeController : Controller
    {
        UcururContext db;


        public HomeController()
        {
            db = new UcururContext();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();

        }


        public ActionResult Uye()
        {
            return View();
        }
    }
}