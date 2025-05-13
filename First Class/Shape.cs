using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Class
{
    public class Shape
    {
       public string color;
       public double area;
        public Shape(string color)
        {
            this.color = color;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Color: {color},Area: {area}");
        }
    }
}
