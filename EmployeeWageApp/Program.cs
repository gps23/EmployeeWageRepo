using System;
using EmployeeWageApp.UseCases;

namespace EmployeeWageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Employee Wage Computation ===");
            Console.WriteLine("Choose Use Case:");
            Console.WriteLine("1. Employee Presence Check");
            Console.WriteLine("2. Daily Wage Calculation");
            Console.WriteLine("3. Part-Time Wage Calculation");
            Console.Write("Enter choice: ");

            // Validate input
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                return;
            }

            switch (choice)
            {
                case 1:
                    new EmployeePresence().Execute();
                    break;

                case 2:
                    new DailyWage().Execute();
                    break;

                case 3:
                    new PartTimeWage().Execute();
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select a valid option (1–3).");
                    break;
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
