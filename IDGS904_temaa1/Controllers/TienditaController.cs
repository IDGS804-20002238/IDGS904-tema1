using IDGS904_temaa1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_temaa1.Controllers
{
    public class TienditaController : Controller
    {
        // GET: Tiendita
        public ActionResult Index()
        {
            var alumno = new Alumnos()
            {
                Nombre = "Pedro",
                Edad=20,
                Activo=false,
                Inscrito=new DateTime(2023,1,1)
            };
            ViewBag.Alumnos = alumno;
            return View();
        }

        public ActionResult Registrar() {

            return View();
        }

        public ActionResult Calculo()
        {
            double resultado = 0;
            if (TempData.ContainsKey("Resultado"))
            {
                resultado = (double)TempData["Resultado"];
            }
            ViewBag.valor=resultado;

            return View();
        }

        public RedirectToRouteResult Result(FtoC f)
        {
            TempData["Resultado"] = f.CaF();
            return RedirectToAction("Calculo");
        }
    }
}