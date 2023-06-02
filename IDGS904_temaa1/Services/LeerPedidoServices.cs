using System;
using System.IO;
using System.Web;
using IDGS904_temaa1.Models;

namespace IDGS904_temaa1.Services
{
    public class LeerPedidoServices
    {
        public Array LeerArchivo()
        {
            Array datos = null;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/pedidos.txt");
            if (File.Exists(archivo))
            {
                datos = File.ReadAllLines(archivo);
            }

            return datos;
        }
    }
}
