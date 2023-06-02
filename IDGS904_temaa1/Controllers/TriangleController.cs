using IDGS904_temaa1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_temaa1.Controllers
{
    public class TriangleController : Controller
    {
        public ActionResult Index()
        {
            var model = new TriangleModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Verify(TriangleModel model)
        {
            if (ModelState.IsValid)
            {
                double side1 = CalculateSideLength(model.X1, model.Y1, model.X2, model.Y2);
                double side2 = CalculateSideLength(model.X2, model.Y2, model.X3, model.Y3);
                double side3 = CalculateSideLength(model.X3, model.Y3, model.X1, model.Y1);

                Math.Round(side1, 2);
                Math.Round(side2, 2);
                Math.Round(side3, 2);

                if (IsTriangleValid(side1, side2, side3))
                {
                    model.IsValidTriangle = true;
                    model.TriangleType = GetTriangleType(side1, side2, side3);
                    model.Area = CalculateTriangleArea(side1, side2, side3);
                }
                else
                {
                    model.IsValidTriangle = false;
                    model.ErrorMessage = "Los puntos no forman un triángulo válido.";
                }
            }

            return View("Index", model);
        }

        private double CalculateSideLength(double x1, double y1, double x2, double y2)
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        private bool IsTriangleValid(double side1, double side2, double side3)
        {
            return side1 + side2 > side3 && side2 + side3 > side1 && side3 + side1 > side2;
        }

        private string GetTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilátero";
            }
            else if (side1 == side2 || side2 == side3 || side3 == side1)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";
            }
        }

        private double CalculateTriangleArea(double side1, double side2, double side3)
        {
            double semiPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }
    }
}