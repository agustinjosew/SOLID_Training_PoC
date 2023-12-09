using OCP.Resolving;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class AreaCalculator_ResolvingOCP
    {
        public double CalculateArea(Shape[] shapes)
        {
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.CalculateArea();
            }
            return totalArea;
        }

         //Using this layout, AreaCalculator does not need to know the details of how the area of ​​each shape is calculated;
         //it simply calls the CalculateArea method, which each concrete form has implemented.
         //This complies with the open/closed principle,
         //since AreaCalculator is closed for modifications(you don't need to change it when new shapes are added)
         //and shapes are open for extension(you can easily add new shapes).
    }
}
