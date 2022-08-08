using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{

    /// <summary>
    ///  Here We Check Employee Wage For Month .
    /// </summary>
    public class EmployeeWageForMonth
    {
        // constants

        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;

        /// <summary>
        /// Checks the emp wage for month.
        /// </summary>
        public void CheckEmpWageForMonth()
        {
            //variables

            int empWage = 0;
            int empHrs = 0;
            int totalEmpWage = 0;

            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(3);

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = EMP_RATE_PER_HOUR * empHrs;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage: " + empWage);
            }
            Console.WriteLine("total Emp Wage: " + totalEmpWage);
        }
    }
}

