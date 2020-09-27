using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contants
            int IS_FULL_TIME = 2;
            int IS_PART_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            //Variables
            int empHrs =0;
            int empWage =0;
            Random random = new Random();
            //Computations
            int empCheck = random.Next(0, 3);
            if(empCheck == IS_PART_TIME)
            {
                empHrs = 4;    
            }
            if(empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
