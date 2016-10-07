using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicketingSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Service Desk Help Center is committed to providing excellent customer service. When a customer has a technical issue, they choose us.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Questions or concerns? Our contact information is listed below.";

            return View();
        }
        public ActionResult Chat()
        {
            ViewBag.Message = "Chat with an online professional technician. We are here to help resolve any technical issues or concerns you may have.";

            return View();
        }
    }
}