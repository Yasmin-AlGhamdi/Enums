using System;

namespace UsingEnum
{
    class Program
    {
        
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday}
        public enum Borderside: byte { Left = 1, Right = 2, Top = 10, Bottom = 11 }

        [Flags] // Used to print the name itself and not the number. It has to be exactly on top of the enum you want to use it on.
        enum BorderSide { None = 0, Left = 1, Right = 2, Top = 4, Bottom = 8 }
        static void Main(string[] args)
        {
            Days day = Days.Friday;
            Console.WriteLine(day);

            Console.WriteLine("-------------------------------------------------------------------------------");

            int weekdayStart = (int)Days.Sunday;
            int weekdayEnd = (int)Days.Thursday;

            Days sun = (Days)weekdayStart;

            Console.WriteLine("The day is: "+sun);
            Console.WriteLine("Sunday: {0}",weekdayStart);
            Console.WriteLine("Thursday: {0}",weekdayEnd);

            Console.WriteLine("-------------------------------------------------------------------------------");

            int i = (int)Borderside.Left;
            Borderside side = (Borderside)i;
            bool lefOrRight = (int)side <= 2;

            Console.WriteLine(i);
            Console.WriteLine(side);
            Console.WriteLine(lefOrRight);

            Console.WriteLine("-------------------------------------------------------------------------------");

            BorderSide leftRight = BorderSide.Left | BorderSide.Right;

            string formatted = leftRight.ToString();
            Console.WriteLine(formatted);

            Console.ReadKey();
        }
    }
}
