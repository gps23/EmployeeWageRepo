using System;
using EmployeeWageApp.UseCases;

namespace EmployeeWageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Use Case:");
            Console.WriteLine("1. Employee Presence Check");
            Console.WriteLine("2. Daily Wage Calculation");
            Console.Write("Enter choice: ");

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
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
