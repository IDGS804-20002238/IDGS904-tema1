using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_temaa1.Services
{
    public class LeerServices
    {
        public Array LeerArchivo() {
            Array datos = null;
            var infoMaes = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            if (File.Exists(infoMaes)) { 
                   datos=File.ReadAllLines(infoMaes);
            }
            
            return datos;
        }
    }
}