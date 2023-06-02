using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_temaa1.Models
{
    public class Pedido
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Tamano { get; set; }
        public List<string> Ingredientes { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
    }





}
