﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Users.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("Ключ", "Значкние");

            return View(data);
        }
    }
}