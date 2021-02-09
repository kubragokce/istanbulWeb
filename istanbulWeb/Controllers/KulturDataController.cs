using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using istanbulWeb.Models;
using istanbulWeb.Models.Managers;

namespace istanbulWeb.Controllers
{
    public class KulturDataController : Controller
    {
        // GET: KulturData
        public ActionResult Table1()
        {
            webistanbulContext context = new webistanbulContext();
            List<SehirTiyatrolarindaSergilenenOyunlars> tbl1 = context.SehirTiyatrolarindaSergilenenOyunlar.ToList();
            return View(tbl1);
        }
        public ActionResult Table2()
        {
            webistanbulContext context = new webistanbulContext();
            List<TiyatroOyunSayilaris> tbl2 = context.TiyatroOyunSayilari.ToList();
            return View(tbl2);
        }
    }
}