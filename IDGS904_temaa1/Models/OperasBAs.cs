using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace IDGS904_temaa1.Models
{
    public class OperasBAs
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Res { get; set; }

        public string tipo { get; set; }

        public double Sumar() { return (Num1 + Num2); }
        public double Restar() { return (Num1 - Num2); }
        public double Multilicar() { return (Num1 * Num2); }
        public double Dividir() { return (Num1 / Num2); }

        public double Operas() {
            double r = 0;
            if (tipo == "s")
            {
                r=Sumar();
            }

            if (tipo == "r")
            {
                r=Restar();
            }

            if (tipo == "m")
            {
                r=Multilicar();
            }
            if (tipo == "d")
            {
                r=Dividir();
            }
            return r;
        }
    }
}