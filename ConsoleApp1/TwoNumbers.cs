using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class TwoNumbers
    {
        public void checkSum()
        {
            Console.WriteLine("Enter first Number : ");
            float num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            float num2 = Convert.ToInt16(Console.ReadLine());

            float sum = num1 + num2;
            float diff = num1 - num2;

            float sqr1 = sum * sum;
            float sqr2 = diff * diff;

            Console.WriteLine("Square1 is : " + sqr1);
            Console.WriteLine("Square2 is : " + sqr2);
        }
    }
}
