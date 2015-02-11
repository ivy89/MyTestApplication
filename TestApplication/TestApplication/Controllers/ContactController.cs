using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestApplication.Controllers
{
    public class ContactController : Controller
    {
        [Route("Contact")]
        public ActionResult Contact()
        {
            return View();
        }
    }
}