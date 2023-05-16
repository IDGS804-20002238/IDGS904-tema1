using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace IDGS904_temaa1.Models
{
    public class Puntos
    {
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int y1 { get; set; }
        public int y2 { get; set; }




        public double CalcularP()
        {

            double result = Math.Sqrt(Math.Pow((x2 - x1), 2)+Math.Pow((y2 - y1), 2));

            return result;
        }
    }
}