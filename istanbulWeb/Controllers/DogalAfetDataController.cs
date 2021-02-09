using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using istanbulWeb.Models;
using istanbulWeb.Models.Managers;

namespace istanbulWeb.Controllers
{
    public class DogalAfetDataController : Controller
    {
        // GET: DogalAfetData
        public ActionResult Table1()
        {
            webistanbulContext context = new webistanbulContext();
            List<itfaiyeKonums> tbl1 = context.itfaiyeKonum.ToList();
            return View(tbl1);
        }
        public ActionResult Table2()
        {
            webistanbulContext context = new webistanbulContext();
            List<YangininKaynaginiGoreDagilims> tbl2 = context.YangininKaynaginiGoreDagilim.ToList();
            return View(tbl2);
        }
    }
}