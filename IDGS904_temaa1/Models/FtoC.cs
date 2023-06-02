using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_temaa1.Models
{
    public class FtoC
    {
        public double Grados { set; get; }

        public string tipo { set; get; }


        public double CaF() {
            double res=0;
            if (tipo == "f")
            {

                 res = (Grados * 1.8) +32;
            }
            else {
                res = (Grados -32) /1.8;
            }
            return res;
        }

      


    }
}