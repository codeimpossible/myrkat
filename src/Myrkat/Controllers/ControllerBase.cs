﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Myrkat.Controllers
{
    public class ControllerBase: Controller
    {
        public virtual ActionResult Index()
        {
            return View("Index");
        }
    }
}
