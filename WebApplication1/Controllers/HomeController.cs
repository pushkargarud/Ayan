using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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
        public ActionResult Contact(ContactModel contactModel)
        {
            //ViewBag.Message = "Your contact page.";
            if (MailSent(contactModel))
            {
                ViewBag.SendMessage = true;
            }

            return View();
        }
        public bool MailSent(ContactModel model)
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