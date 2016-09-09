﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace Day2.Controllers.Controllers
{
    [SessionState(SessionStateBehavior.Disabled)]
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}