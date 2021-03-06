﻿using System;
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
            ViewBag.Message = "Service Desk Help Center's number one committment is excellent customer service."; 
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Questions or concerns? Our contact information is listed below.";

            return View();
        }
    }
}