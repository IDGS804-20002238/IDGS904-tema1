using IDGS904_temaa1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_temaa1.Controllers
{
    public class PuntosController : Controller
    {
        // GET: Puntos
        public RedirectToRouteResult Calcular(Puntos n)
        {
            var model = new Puntos();
  
            TempData["Resultado"] = n.CalcularP();
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
     
            double resultado = 0;
            if (TempData.ContainsKey("Resultado"))
            {
                resultado = (double)TempData["Resultado"];
            }            
            ViewBag.valor=resultado;
            return View();
        }

    }
}