using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTComputer.Areas.Admin.Controllers
{
    public class ErrorAdminController : Controller
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
