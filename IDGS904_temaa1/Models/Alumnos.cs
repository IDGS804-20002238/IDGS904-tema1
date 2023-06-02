using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_temaa1.Models
{
    public class Alumnos
    {

        public string Nombre { set; get; }
        public int Edad { set; get; }

        public bool Activo { set; get; }
        public DateTime Inscrito { set; get; }


    }
}