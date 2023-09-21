using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class FindNumbers
    {
        public void checkFindNumber()
        {
            for (int i = 2000; i <= 3200; i++)
            {
                if(i%7==0 && i % 5 != 0)
                {
                    Console.Write(i+",");
                }
            }
        }
    }
}
