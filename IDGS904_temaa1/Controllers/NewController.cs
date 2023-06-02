using IDGS904_temaa1.Models;
using IDGS904_temaa1.Services;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_temaa1.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult NuevoSaludo()
        {
            ViewBag.Nombre="RCe";
            return View();
        }

        public ActionResult Vista(string n1, string n2)
        {
            int res = Convert.ToInt32(n1)+Convert.ToInt32(n2);
            ViewBag.resultado=Convert.ToString(res);

            return View();
        }
        public ActionResult Calcular(OperasBAs op) {
            var model = new OperasBAs();

            model.Res=op.Operas();

            return View(model);
        }
        public ActionResult MuestraPulques(OperasBAs op)
        {
            var pulques = new ProductoServices();
            var model = pulques.ObtenerProducto();

            return View(model);
        }
    }
}