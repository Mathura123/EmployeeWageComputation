using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation in Master Branch");
            //Constants
            int IS_FULL_TIME = 2;
            int IS_PART_TIME = 1;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 3);
            if ((empCheck == IS_FULL_TIME) || (empCheck == IS_PART_TIME))
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            int EMP_RATE_PER_HOUR = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            //Computations
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
