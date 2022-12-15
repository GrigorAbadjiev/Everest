using System;
using System.Data;

namespace _05._Everest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            double startingHeight = 5364;
            double target = 8848;
            double currentHeight = 0;
            int days = 1;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }
                if (command == "Yes")
                {
                    days++;
                }
                if (days > 5) break;

                double height = double.Parse(Console.ReadLine());
                currentHeight += height;

                if (currentHeight + startingHeight >= target)
                {
                    break;
                }
            }

            if (startingHeight + currentHeight < target)
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{startingHeight + currentHeight}");
            }
            else
            {
                Console.WriteLine($"Goal reached for {days} days!");
            }
        }
    }
}