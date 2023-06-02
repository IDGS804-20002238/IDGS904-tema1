using IDGS904_temaa1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace IDGS904_temaa1.Services
{
    public class TraductorGuardarService
    {
        public void Guardar(string ingles, string espaniol)
        {
            var datos = espaniol + "," + ingles + System.Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");
            File.AppendAllText(archivo, datos);
        }
    }
}