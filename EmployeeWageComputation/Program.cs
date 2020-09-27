using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("By Switch Case");
            Random random = new Random();
            int EMP_RATE_PER_HOUR=20;
            //variables
            int empWage = 0;
            int empHrs = 0;
            //Computation
            int empCheck = random.Next(0, 3);
            switch(empCheck)
            {
                case 1:
                    empHrs = 4;
                    Console.WriteLine("Is Part Time");
                    break;
                case 2:
                    empHrs = 8;
                    Console.WriteLine("Is Full Time");
                    break;
                case 0:
                    empHrs = 0;
                    Console.WriteLine("Is Absent");
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage :" + empWage);
        }
    }
}
