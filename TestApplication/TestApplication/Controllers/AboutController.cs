using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestApplication.Controllers
{
    public class AboutController : Controller
    {
        [Route("About")]
        public ActionResult About()
        {
            return View();
        }
    }
}