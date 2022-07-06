using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CurriculamVitae.Controllers
{
    public class CvController : Controller
    {
        // GET: Cv
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Student()
        {
            return View();
        }
        public ActionResult Personal()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Project()
        {
            return View();
        }
        public ActionResult Reference()
        {
            return View();
        }
    }
}