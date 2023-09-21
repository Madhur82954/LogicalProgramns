using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Date
    {
        public void checkNextDate()
        {
            Console.WriteLine("Today is :"+DateTime.Today.Year);
            Console.WriteLine("Today is :" + DateTime.Today.Month);
            Console.WriteLine("Today is :" + DateTime.Today.Day);
            Console.WriteLine("Next Date is :" + DateTime.Today.AddDays(1));
        }
    }
}
