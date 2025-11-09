using System;

namespace EmployeeWageApp.UseCases
{
    public class PartTimeWage
    {
        public void Execute()
        {
            Console.WriteLine("Employee Part-Time Wage Calculation:");

            int wagePerHour = 20;
            int fullDayHours = 8;
            int partTimeHours = 4;

            int partTimeWage = wagePerHour * partTimeHours;
            int fullTimeWage = wagePerHour * fullDayHours;

            Console.WriteLine($"Full-Time Wage: ₹{fullTimeWage}");
            Console.WriteLine($"Part-Time Wage: ₹{partTimeWage}");
        }
    }
}
