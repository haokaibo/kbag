using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Request.InputStream
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult SaveItem(string viewParam)
        {
            var viewData = this.ViewData;
            var a = ViewBag;
            return null;
        }

        public ActionResult TestJsonPost(string reqJson)
        {
            return new JsonResult() { Data = "success" };
        }

    }
}
