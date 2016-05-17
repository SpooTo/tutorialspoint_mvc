using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vs_tutorialspoint_mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            int hour = DateTime.Now.Hour;

            if (hour < 12)
            {
                ViewBag.Greeting = "Good Morning. The time is : " + DateTime.Now.ToShortTimeString();
            }
            else
            {
                ViewBag.Greeting = "Good Afternoon. The time is : " + DateTime.Now.ToShortTimeString();
            }

            ViewBag.Date = "And the date is : " + DateTime.Now.ToShortDateString();

            return View();
        }
    }
}