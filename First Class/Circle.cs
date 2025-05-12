using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Class
{
    public class Circle : Shape
    {
        int radius;

        public Circle(int radius,string color):base (color)
        {
            this.radius = radius;
        }
        public void Area()
        {
            int area = radius * radius * 13;
            Console.WriteLine(area);
        }

    }

}
