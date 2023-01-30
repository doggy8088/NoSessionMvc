using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace NoSessionMvc.Controllers
{
    public class SessionController : BaseController
    {
        public ActionResult LongRunning()
        {
            Session["State"] = "LongRunning";

            Thread.Sleep(1000 * 10); // 10 seconds

            return Content("Done");
        }

    }
}