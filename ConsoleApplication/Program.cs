using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nate Brown";
            string location = "Utah";

            Console.WriteLine($"{"My name is "}{name}.");
            Console.WriteLine($"{"I am from "}{location}");

            DateTime theDate = new DateTime(2020, 4, 24, 0, 0, 0);

            Console.WriteLine($"{"The date is "}{theDate.Date:MM/dd/yyyy}");


            DateTime today = DateTime.Now;
            DateTime christmas = new DateTime(2020, 12, 25);

            int timeLeft = (christmas - today).Days;

            Console.WriteLine($"{"There are "}{timeLeft}{" days until Christmas"}");

            Console.WriteLine("\nPress any key to enter the program.");
            Console.ReadKey();
            double width, height, woodLength, glassArea;

            string widthString, heightString;
            Console.WriteLine("\nPlease enter the width in feet. ");
            widthString = Console.ReadLine();

            width = double.Parse(widthString);
            Console.WriteLine("\nPlease enter the height in feet. ");
            heightString = Console.ReadLine();

            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("\nThe length of the wood is " +
            woodLength + " feet");

            Console.WriteLine("\nThe area of the glass is " +
            glassArea + " square metres");

            Console.WriteLine("\nPress any key to exit the program.");
            Console.ReadKey();


        }
    }
}
