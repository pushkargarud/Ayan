﻿using AyanMusic.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AyanMusic.Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Msg = "Hellow World";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(ContactViewModel contactModel)
        {
            if (SendMail(contactModel))
            {
                ViewBag.Mailsent = true;
            }
            return View();
        }
        public bool SendMail(ContactViewModel contactModel)
        {
            return true;
        }

        public ActionResult UnderConstruction()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Team()
        {
            return View();
        }
    }
}