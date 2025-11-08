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
            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    new EmployeePresence().Execute();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
