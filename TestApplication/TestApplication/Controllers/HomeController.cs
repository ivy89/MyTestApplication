﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestApplication.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]       
        public ActionResult Home()
        {
            return View();
        }
    }
}