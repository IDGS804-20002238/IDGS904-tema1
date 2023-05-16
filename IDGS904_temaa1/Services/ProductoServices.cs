using IDGS904_temaa1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_temaa1.Services
{
    public class ProductoServices
    {
        public List<Productos> ObtenerProducto() {

            var producto1 = new Productos()
            {
                Nombre="pulque",
                Descripcccion="Frutis rojos",
                Cantidad=10,
                Produccioin= new DateTime(2023, 11, 5)

            };
            var producto2 = new Productos()
            {
                Nombre="pulque2",
                Descripcccion="Mazapan",
                Cantidad=5,
                Produccioin= new DateTime(2023, 10, 6)

            };
            return new List<Productos> {producto1, producto2 };
        }
    }
}