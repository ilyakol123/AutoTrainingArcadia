using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_2
{
    class Rectangle
    {
        private double Side1 { get; set; }
        private double Side2 { get; set; }
        private double Perimeter { get; set; }
        private double Area { get; set; }

        public Rectangle(double side1, double side2)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }

        public void AreaCalculator()
        {
            this.Area = this.Side1 * this.Side2;
            Console.WriteLine($"Rectangle area = {this.Area}");
        }

        public void PerimeterCalculator()
        {
            this.Perimeter = 2 * (this.Side1 + this.Side2);
            Console.WriteLine($"Rectangle perimeter = {this.Perimeter}");
        }
    }
}
