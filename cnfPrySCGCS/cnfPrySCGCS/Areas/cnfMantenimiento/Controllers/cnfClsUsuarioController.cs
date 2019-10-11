using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cnfPrySCGCS.Areas.cnfMantenimiento.Controllers
{
    public class cnfClsUsuarioController : Controller
    {
        // GET: cnfMantenimiento/cnfClsUsuario
        public ActionResult cnfFrmUsuarioVista()
        {
            return View();
        }
    }
}