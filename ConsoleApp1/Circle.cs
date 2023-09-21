using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Circle
    {
        public void checkArea()
        {
            double pi = 3.14;
            Console.WriteLine("Enter Diameter");
            int dia = Convert.ToInt16(Console.ReadLine());
            double area = pi * (dia/2) * (dia/2);
            Console.WriteLine("Area is : "+area);
            double perimeter = 2 * pi * (dia/2);
            Console.WriteLine("Perimeter is : "+perimeter);
        }
    }
}
