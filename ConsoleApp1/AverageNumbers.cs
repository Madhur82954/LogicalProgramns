using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class AverageNumbers
    {
        public void CheckAverage()
        {
            Random random = new Random();
            int num1 = random.Next(10, 50);
            int num2 = random.Next(10, 50);
            int num3 = random.Next(10, 50);
            int num4 = random.Next(10, 50);
            int num5 = random.Next(10, 50);
            int average = (num1 + num2 + num3 + num4 + num5) / 5;
            Console.WriteLine(num1+" "+num2+" "+num3+" "+num4+" "+num5);
            Console.WriteLine("Average is : "+average);
        }
    }
}
