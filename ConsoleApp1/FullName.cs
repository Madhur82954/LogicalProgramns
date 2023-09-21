using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class FullName
    {
        public void checkFullName()
        {
            Console.WriteLine("Enter Name :");
            string name = Console.ReadLine();
            var names = name.Split(' ');
            string firstname = names[0];
            string lastname = names[1];
            Console.WriteLine("FirstName : "+firstname);
            Console.WriteLine("LastName : "+lastname);
        }
    }
}
