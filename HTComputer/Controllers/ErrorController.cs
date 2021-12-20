using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTComputer.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult NotFoundPage()
        {
            return View();
        }

        public ActionResult ServerError()
        {
            return View();
        }
    }
}
