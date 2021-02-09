using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using istanbulWeb.Models;
using istanbulWeb.Models.Managers;

namespace istanbulWeb.Controllers
{
    public class SporDataController : Controller
    {
        // GET: SporData
        public ActionResult Table1()
        {
            webistanbulContext context = new webistanbulContext();
            List<SporOrganizasyonuveSporcuSayilaris> spor = context.SporOrganizasyonuveSporcuSayilari.ToList();

            //var spor = context.SporOrganizasyonuveSporcuSayilari.ToList();
            return View(spor);
        }
    }
}