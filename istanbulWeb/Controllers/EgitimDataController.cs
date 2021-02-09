using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using istanbulWeb.Models;
using istanbulWeb.Models.Managers;

namespace istanbulWeb.Controllers
{
    public class EgitimDataController : Controller
    {
        // GET: Tables
        public ActionResult Table1()
        {
            webistanbulContext context = new webistanbulContext();
            List<ilceBazliOkumaYazmaBilenBilmeyenKisiSayisis> tbl1 = context.ilceBazliOkumaYazmaBilenBilmeyenKisiSayisi.ToList();
            return View(tbl1);
        }
        public ActionResult Table2()
        {
           webistanbulContext context = new webistanbulContext();
            List<OgrenciSayilaris> tbl2 = context.OgrenciSayilari.ToList();
            return View(tbl2);
        }
    }
}