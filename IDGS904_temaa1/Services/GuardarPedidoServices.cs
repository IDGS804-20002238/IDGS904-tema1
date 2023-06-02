using System;
using System.IO;
using System.Web;
using IDGS904_temaa1.Models;

namespace IDGS904_temaa1.Services
{
    public class GuardarPedidoServices
    {
        public void GuardarArchivo(Pedido pedido)
        {
            var datos = $"{pedido.Tamano},{pedido.Cantidad},{string.Join(",", pedido.Ingredientes)},{pedido.Subtotal},{pedido.Total}{Environment.NewLine}";
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/pedidos.txt");
            File.AppendAllText(archivo, datos);
        }
    }
}
