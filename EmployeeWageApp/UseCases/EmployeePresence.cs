using System;

namespace EmployeeWageApp.UseCases
{
    public class EmployeePresence
    {
        public void Execute()
        {
            Console.WriteLine("Employee Presence Check:");

            Random random = new Random();
            int empCheck = random.Next(0, 2); // 0 = Absent, 1 = Present

            if (empCheck == 1)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
