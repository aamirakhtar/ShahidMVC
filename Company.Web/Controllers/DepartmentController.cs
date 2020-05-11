using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Company.Web.Controllers
{
    public class DepartmentController : Controller
    {
        public string Index()
        {
            return "Welcome from Department";
        }

        [NonAction]
        public ActionResult Welcome()
        {
            return View();
        }

        public string WelcomeWithDate()
        {
            return "Welcome Shahid" + DateTime.Now;
        }
    }
}