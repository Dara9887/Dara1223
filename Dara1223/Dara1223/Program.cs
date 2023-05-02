using Dara1223;
using System;

namespace Dara1223
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the MathsTutor Game!");

            Tutorial.ShowInstructions();

            Statistics statistics = new Statistics();

            while (true)
            {
                Console.WriteLine("1. Show instructions");
                Console.WriteLine("2. Deal 3 cards");
                Console.WriteLine("3. Deal 5 cards");
                Console.WriteLine("4. Save statistics to file");
                Console.WriteLine("5. Quit");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        Tutorial.ShowInstructions();
                    }
                    else if (choice == 2)
                    {
                        var pack = new Pack(statistics);
                        pack.DealCards(3);
                    }
                    else if (choice == 3)
                    {
                        var pack = new Pack(statistics);
                        pack.DealCards(5);
                    }
                    else if (choice == 4)
                    {
                        string filePath = "statistics.txt";
                        statistics.SaveToFile(filePath);
                        Console.WriteLine($"Statistics saved to {filePath}");
                    }
                    else if (choice == 5)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            Console.WriteLine("Thank you for playing the MathsTutor Game! Goodbye!");
        }
    }
}