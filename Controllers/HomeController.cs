﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntiTrees.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Videos()
        {
            ViewBag.Message = "Videos page.";

            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Message = "Gallery page.";

            return View();
        }

        public ActionResult Growth()
        {
            ViewBag.Message = "Growth page.";

            return View();
        }

        public ActionResult Shop()
        {
            ViewBag.Message = "Shop page.";

            return View();
        }

        public ActionResult ShoppingCart()
        {
            ViewBag.Message = "Shop page.";

            return View();
        }
    }
}
