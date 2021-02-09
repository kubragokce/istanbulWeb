using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using istanbulWeb.Models;
using istanbulWeb.Models.Managers;

namespace istanbulWeb.Controllers
{
    public class NufusDataController : Controller
    {
        // GET: NufusData
        public ActionResult Table1()
        {
            webistanbulContext context = new webistanbulContext();
            List<NufusBilgileris> tbl1 = context.NufusBilgileri.ToList();
            return View(tbl1);
        }
        public ActionResult Table2()
        {
            webistanbulContext context = new webistanbulContext();
            List<HalkHaneBuyukluguSayisis> tbl2 = context.HalkHaneBuyukluguSayisi.ToList();
            return View(tbl2);
        }
    }
}