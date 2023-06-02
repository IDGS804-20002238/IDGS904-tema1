using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_temaa1.Models
{
    public class tiendita
    {
        public double Grados { get; set; }
        public string ConvertirACelsius { get; set; }
        public string Resultado { get; set; }

        public void ConvertirGrados()
        {
            if (ConvertirACelsius == "Celsius")
            {
                // Convertir de Fahrenheit a Celsius
                double celsius = (Grados - 32) * 5 / 9;
                Resultado = $"El resultado es {celsius} °C";
            }
            else
            {
                // Convertir de Celsius a Fahrenheit
                double fahrenheit = (Grados * 9 / 5) + 32;
                Resultado = $"El resultado es {fahrenheit} °F";
            }
        }
    }
}