using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class PlaceName
    {
        public void checkPlaceName()
        {
            Console.WriteLine("Enter place : ");
            string place = Console.ReadLine();

            string place1 = place.ToUpper();
            string place2 = place.ToLower();

            Console.WriteLine("place name is : " + place1);
            Console.WriteLine("place name is : " + place2);
        }
    }
}
