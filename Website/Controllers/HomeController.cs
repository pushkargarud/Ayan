using System.Web.Mvc;
using AyanMusic.Website.Models;

namespace AyanMusic.Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() => View(new HomeViewModel
        {
            PageTitle = "Hello World"
        });

        public ActionResult About() => View(new AboutViewModel
        {
            PageTitle = "Your application description page.",
            Message = "This is my message"
        });

        public ActionResult Contact() => View(new ContactViewModel
        {
            PageTitle = "Your contact page.",
            Message = "This is my message."
        });

        public ActionResult UnderConstruction() => View(new UnderConstructionViewModel
        {
            PageTitle = "Under construction"
        });

        public ActionResult Team() => View(new TeamViewModel
        {
            PageTitle = "Team view page"
        });
    }
}