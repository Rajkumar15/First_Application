﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_application.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        public ActionResult Change()
        {
            var a = 10;
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult RahulBranch()
        {
            return View();
        }
    }
}