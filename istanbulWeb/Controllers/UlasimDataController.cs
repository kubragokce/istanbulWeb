using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using istanbulWeb.Models;
using istanbulWeb.Models.Managers;

namespace istanbulWeb.Controllers
{
    public class UlasimDataController : Controller
    {
        // GET: UlasimData
        public ActionResult Table1()
        {
            webistanbulContext context = new webistanbulContext();
            List<DenizİsletmeleriBazindaYolcus> tbl1 = context.DenizİsletmeleriBazindaYolcu.ToList();
            return View(tbl1);
        }
        public ActionResult Table2()
        {
            webistanbulContext context = new webistanbulContext();
            List<KarayollariBazindaAracVeHatSayisis> tbl2 = context.KarayollariBazindaAracVeHatSayisi.ToList();
            return View(tbl2);
        }
        public ActionResult Table3()
        {
            webistanbulContext context = new webistanbulContext();
           List<KarayollariBazindaYolculukSayisis> tbl3 = context.KarayollariBazindaYolculukSayisi.ToList();
            return View(tbl3);
        }
        
        public ActionResult Table5()
        {
            webistanbulContext context = new webistanbulContext();
            List<RayliSistemlerİnternetSiteleris> tbl5 = context.RayliSistemlerİnternetSiteleri.ToList();
            return View(tbl5);
        }
        public ActionResult Table6()
        {
            webistanbulContext context = new webistanbulContext();
            List<RayliTamamlanmisSantiyes> tbl6 = context.RayliTamamlanmisSantiye.ToList();
            return View(tbl6);
        }
        public ActionResult Table7()
        {
            webistanbulContext context = new webistanbulContext();
            List<RaylıiSisHatBazliSefers> tbl7 = context.RaylıiSisHatBazliSefer.ToList();
            return View(tbl7);
        }
        public ActionResult Table8()
        {
            webistanbulContext context = new webistanbulContext();
            List<YolculukTuruBazindaYolcus> tbl8 = context.YolculukTuruBazindaYolcu.ToList();
            return View(tbl8);
        }
        public ActionResult Table9()
        {
            webistanbulContext context = new webistanbulContext();
            List<istasyonlars> tbl9 = context.istasyonlar.ToList();
            return View(tbl9);
        }
    }
}