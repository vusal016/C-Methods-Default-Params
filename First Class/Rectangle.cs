using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Class
{
    public class Rectangle : Shape
    {
        int Length;

        public Rectangle(int length,string color): base (color)
        {
            Length = length;
        }
        public void Area()
        {
            int area = Length * 13;
            Console.WriteLine(area);
        }
        //Not: Burda taskda sahe hesablamasi ucun 2 deyisen lazimdir
        //length var amma eni yoxdur color ise hec bir elaqe yaratmir.
        //buna gore de 13 reqemini pi ye istinaden ozumden yazdim.
    }

}          
