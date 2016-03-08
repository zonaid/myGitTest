using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestGit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Age = "36 years old";

            ViewBag.Title = "This is my Home Page";

            return View();
        }
    }
}
