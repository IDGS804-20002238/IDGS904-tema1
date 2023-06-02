using IDGS904_temaa1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_temaa1.Services
{
    public class GuardarServices
    {
        public void GuardaArchivo(Maestros m) {

            var nombre = m.Nombre;
            var apaterno = m.Apaterno;
            var amaterno = m.Amaterno;
            var edad = m.Edad;
            var email = m.Email;

            var datos = nombre+","+apaterno+","+amaterno+","+edad+","+email+Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            //File.WriteAllText(archivo, datos);
            File.AppendAllText(archivo, datos);
            
                }
    }
}