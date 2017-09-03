﻿using System.Web.Mvc;

namespace Teapot.Web.Controllers
{
    public class TeapotController : Controller
    {
        public ActionResult Teapot()
        {
            return Redirect("https://www.ietf.org/rfc/rfc2324.txt");
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
