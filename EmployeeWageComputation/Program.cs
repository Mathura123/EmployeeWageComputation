using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int NO_OF_WORKING_DAY_PER_MONTH = 20;
            int EMP_WAGE_PER_HOUR = 20;
            //variables
            int empWage = 0;
            int empHrs = 0;
            int TOTAL_MONTH_WAGE = 0;
            //Computation
            int empCheck = random.Next(0, 3);
            switch(empCheck)
            {
                case 0:
                    empHrs = 0;
                    break;
                case 1:
                    empHrs = 4;
                    break;
                case 2:
                    empHrs = 8;
                    break;
            }
            TOTAL_MONTH_WAGE = empHrs * EMP_WAGE_PER_HOUR * NO_OF_WORKING_DAY_PER_MONTH;
            Console.WriteLine("Total Wage per month is " + TOTAL_MONTH_WAGE);
        }
    }
}
