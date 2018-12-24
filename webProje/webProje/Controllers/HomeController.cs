﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using WebProje.DAL;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class HomeController : Controller
    {
        private VeriContext db = new VeriContext();
        public ActionResult Index()
        {
            var model = new HomeIndexViewModel() {
                Haber = db.Haberler.ToList()
            };
            return View(model);
        }
    }
}