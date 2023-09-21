using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Option \n1)Friends Name \n2)TwoNumbers \n3)PlaceName \n4)StringNumber \n5)FullName \n6)AverageNumber \n7)Circle \n8)Date \n9)StopWatch \n10)FindNumbers");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FriendsName friends = new FriendsName();
                    friends.CheckFriendsName();
                    break;
                case 2:
                    TwoNumbers two = new TwoNumbers();
                    two.checkSum();
                    break;
                case 3:
                    PlaceName place = new PlaceName();
                    place.checkPlaceName();
                    break;
                case 4:
                    StringNumber number = new StringNumber();
                    number.checkstringNumber();
                    break;
                case 5:
                    FullName full = new FullName();
                    full.checkFullName();
                    break;
                case 6:
                    AverageNumbers average = new AverageNumbers();
                    average.CheckAverage();
                    break;
                case 7:
                    Circle circle = new Circle();
                    circle.checkArea();
                    break;
                case 8:
                    Date date = new Date();
                    date.checkNextDate();
                    break;
                case 9:
                    StopWatch stop = new StopWatch();
                    stop.CheckTime();
                    break;
                case 10:
                    FindNumbers find = new FindNumbers();
                    find.checkFindNumber();
                    break;
            }
        }
    }
}
