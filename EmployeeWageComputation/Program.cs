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
            Console.WriteLine("By Switch Case");
            //Computation
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
            int NO_OF_WORKING_DAY_PER_MONTH = 20;
            //variables
            int TOTAL_MONTH_WAGE = 0;
            //Computation
            TOTAL_MONTH_WAGE = empHrs * EMP_RATE_PER_HOUR * NO_OF_WORKING_DAY_PER_MONTH;
            Console.WriteLine("Total Wage per month is " + TOTAL_MONTH_WAGE);
       
            Random randomNo = new Random();
            int dayReachedOrNOT = randomNo.Next(0, 2);
            switch(dayReachedOrNOT)
            {
                case 0:
                    empHrs = 100;
                    break;
                case 1:
                    empHrs = 8 * 20;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage is "+ empWage);
        }
    }
}
