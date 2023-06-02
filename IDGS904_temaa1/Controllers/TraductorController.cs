using IDGS904_temaa1.Models;
using IDGS904_temaa1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_temaa1.Controllers
{
    public class TraductorController : Controller
    {
        private readonly TraductorGuardarService _traductorGuardarService;

        public TraductorController()
        {
            _traductorGuardarService = new TraductorGuardarService();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Guardar(Traductor traductor)
        {
            _traductorGuardarService.Guardar(traductor.Ingles, traductor.Espaniol);
            return RedirectToAction("Index");
        }

        public ActionResult Mostrar()
        {
            var archivo = Server.MapPath("~/App_Data/traductor.txt");
            var lineas = new List<string>();

            if (System.IO.File.Exists(archivo))
            {
                lineas = new List<string>(System.IO.File.ReadAllLines(archivo));
            }

            return View(lineas);
        }



        public ActionResult Buscar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Buscar(string texto, string idioma)
        {
            var archivo = Server.MapPath("~/App_Data/traductor.txt");
            var lineas = new List<string>(System.IO.File.ReadAllLines(archivo));
            var traduccion = string.Empty;

            foreach (var linea in lineas)
            {
                var valores = linea.Split(',');

                if (idioma == "ingles" && valores[0] == texto)
                {
                    traduccion = valores[1];
                    break;
                }
                else if (idioma == "espanol" && valores[1] == texto)
                {
                    traduccion = valores[0];
                    break;
                }
            }

            if (string.IsNullOrEmpty(traduccion))
            {
                ViewBag.Mensaje = "No se encontró traducción.";
            }
            else
            {
                ViewBag.Traduccion = traduccion;
            }

            return View();
        }
    }
}