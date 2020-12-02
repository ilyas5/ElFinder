﻿using ElFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElFinder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string subFolder)
        {
            FileViewModel model = new FileViewModel { Folder = "Files", SubFolder = subFolder };
            return View(model);
        }

       
    }
}