using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using istanbulWeb.Models;
using istanbulWeb.Models.Managers;

namespace istanbulWeb.Controllers
{
    public class CevreDataController : Controller
    {
        // GET: CevreData
        public ActionResult Table1()
        {
            webistanbulContext context = new webistanbulContext();
            List<dogalgazTuketimverileris> tbl1 = context.dogalgazTuketimverileri.ToList();
            return View(tbl1);
        }
       
        public ActionResult Table3()
        {
            webistanbulContext context = new webistanbulContext();
            List<ToplananKatiAtikMiktarlaris> tbl3 = context.ToplananKatiAtikMiktarlari.ToList();
            return View(tbl3);
        }
        public ActionResult Table4()
        {
            webistanbulContext context = new webistanbulContext();
            List<GeriKazanilanatikMiktars> tbl4 = context.GeriKazanilanatikMiktar.ToList();
            return View(tbl4);
        }
        public ActionResult Table5()
        {
            webistanbulContext context = new webistanbulContext();
            List<GemiAtikTuruveMiktaris> tbl5 = context.GemiAtikTuruveMiktari.ToList();
            return View(tbl5);
        }
        public ActionResult Table6()
        {
            webistanbulContext context = new webistanbulContext();
            List<ToplamatikGeriKazanimOranis> tbl6 = context.ToplamatikGeriKazanimOrani.ToList();
            return View(tbl6);
        }
        public ActionResult Table7()
        {
            webistanbulContext context = new webistanbulContext();
            List<YeniYapilanYesilAlanMiktaris> tbl7 = context.YeniYapilanYesilAlanMiktari.ToList();
            return View(tbl7);
        }
        public ActionResult Table8()
        {
            webistanbulContext context = new webistanbulContext();
            List<GunesUretimMiktarlaris> tbl8 = context.GunesUretimMiktarlari.ToList();
            return View(tbl8);
        }

    }
}