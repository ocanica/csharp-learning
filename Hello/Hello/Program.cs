using System;

namespace Hello
{
    public class Project
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleae type in your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("How many hours of sleep did you have?");
            int hoursOfSleep = int.Parse(Console.ReadLine());
            Console.WriteLine($"Good Morning {name}");

            if (hoursOfSleep >= 8)
            {
                Console.WriteLine($"Great, you had {hoursOfSleep} hours of sleep!");
            } else
            {
                Console.WriteLine("You didn't get enough sleep.");
            }                     
        }
    }
}