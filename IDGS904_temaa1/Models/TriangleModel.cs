using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IDGS904_temaa1.Models
{
    public class TriangleModel
    {
        [Required]
        public double X1 { get; set; }

        [Required]
        public double Y1 { get; set; }

        [Required]
        public double X2 { get; set; }

        [Required]
        public double Y2 { get; set; }

        [Required]
        public double X3 { get; set; }

        [Required]
        public double Y3 { get; set; }

        public bool IsValidTriangle { get; set; }

        public string TriangleType { get; set; }

        public double Area { get; set; }

        public string ErrorMessage { get; set; }
    }
}