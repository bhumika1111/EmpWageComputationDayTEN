using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{

    /// <summary>
    /// Here  We Check Employee Is Present For How Many Hours In Company  And He Complited His Work In How Many Days.
    /// </summary>
    public class EmployeeWageHrsInMonth
    {
        //constants

        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        /// <summary>
        /// Check Employee Hrs Or Day In Month.
        /// </summary>
        public void CheckEmpWageHrsOrDayInMonth()
        {

            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;

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
                totalEmpHrs += empHrs;
                Console.WriteLine(" Day: " + totalWorkingDays + " EmpHrs:" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
        }
    }
}
