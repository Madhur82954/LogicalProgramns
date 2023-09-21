using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class StringNumber
    {
        public void checkstringNumber()
        {
            Console.WriteLine("Enter number");
            string num1 = Console.ReadLine();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(num1);
            }
        }
    }
}
