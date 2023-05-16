using IDGS904_temaa1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_temaa1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public JsonResult Index()
        {

            //retornar texto --return Content("<h1> Roberto <br/> Caridel</h1>");
            var pulque = new Productos() {
                Nombre = "pulque1",
                Descripcccion = "fresa",
                Cantidad=10,
                Produccioin= new DateTime(2023, 11, 2)
            };
            return Json(pulque, JsonRequestBehavior.AllowGet);
            //return View();
        }
        public RedirectResult vista()
        {
            return Redirect("https://google.com.mx");
        }

        public RedirectToRouteResult Vista2() {
            //este metodo es para redirigir a una pantalla dentro del sistema, primero pones la vista
            //en este caso es el index
            //despues el controlador que es el home
            //return RedirectToAction("Index","Home");
            TempData["nombre"] = "Leonel";
            return RedirectToAction("Index2");
        }

        public ActionResult Index2()
        {
            ViewBag.Grupo = "IDGS904";
            ViewData["Materia"] = "DWI";
            string nombre = "";
            if (TempData.ContainsKey("Nombre")) {
                nombre = TempData["Nombre"] as string;
            }
            ViewBag.valor=nombre;
            return View();
        }
    }
}