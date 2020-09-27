using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
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
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Emp Wage is "+ empWage);
        }
    }
}
