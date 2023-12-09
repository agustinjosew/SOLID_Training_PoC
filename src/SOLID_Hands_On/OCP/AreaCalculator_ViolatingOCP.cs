using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class AreaCalculator_ViolatingOCP
    {
        public double CalculateArea(Rectangle[] rectangles)
        {
            double totalArea = 0;
            foreach (var rectangle in rectangles)
            {
                totalArea += rectangle.Width * rectangle.Height;
            }
            return totalArea;
        }

        //In this example, the AreaCalculator class violates OCP because adding support for new shapes
        //would require modifying the existing code, potentially introducing bugs.
    }
}
