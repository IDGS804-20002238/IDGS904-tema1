using IDGS904_temaa1.Models;
using IDGS904_temaa1.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_temaa1.Controllers
{
    public class PedidoController : Controller
    {
        private readonly GuardarPedidoServices _guardarPedidoServices;
        private readonly LeerPedidoServices _leerPedidoServices;

        public PedidoController()
        {
            _guardarPedidoServices = new GuardarPedidoServices();
            _leerPedidoServices = new LeerPedidoServices();
        }

        public ActionResult Index()
        {
            var pedido = new Pedido
            {
                Ingredientes = new List<string> { "Pepperoni", "Piña", "Chorizo" }
            };

            return View(pedido);
        }


        [HttpPost]
        public ActionResult Guardar(Pedido pedido)
        {
            pedido.Subtotal = CalcularSubtotal(pedido);
            pedido.Total = CalcularTotal(pedido);

            _guardarPedidoServices.GuardarArchivo(pedido);

            return RedirectToAction("Confirmacion", new { total = pedido.Total });
        }

        public ActionResult Confirmacion(decimal total)
        {
            return View(total);
        }


        public ActionResult Mostrar()
        {
            var lineas = _leerPedidoServices.LeerArchivo();
            var lineasString = string.Join(",", lineas);

            return View(lineasString);
        }



        private decimal CalcularSubtotal(Pedido pedido)
        {
            decimal costoPizza;
            switch (pedido.Tamano)
            {
                case "chica":
                    costoPizza = 40;
                    break;
                case "mediana":
                    costoPizza = 50;
                    break;
                case "grande":
                    costoPizza = 70;
                    break;
                default:
                    return 0; // Tamaño inválido
            }

            decimal costoIngredientes = pedido.Ingredientes.Count * 10;
            decimal subtotal = (costoPizza + costoIngredientes) * pedido.Cantidad;

            return subtotal;
        }

        private decimal CalcularTotal(Pedido pedido)
        {
            decimal subtotal = CalcularSubtotal(pedido);
            decimal total = subtotal; // No hay otros costos adicionales en este caso

            return total;
        }
    }
}
