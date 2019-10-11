using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cnfPrySCGCS.Areas.cnfMantenimiento.Controllers
{
    public class cnfClsEntregableController : Controller
    {
        // GET: cnfMantenimiento/cnfClsEntregable
        public ActionResult cnfFrmEntregableVista()
        {
            return View();
        }


        public ActionResult cnfFrmEntregableRelacionVista()
        {
            return View();
        }

    }
}