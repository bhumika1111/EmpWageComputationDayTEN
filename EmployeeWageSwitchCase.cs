using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    /// <summary>
    /// Here We Check Employee Wage Using Switch Case. 
    /// <summary>

    public class EmployeeWageSwitchCase
    {
            // constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        /// <summary>
        /// Check Employee Attendance.
        /// </summary>
        public  void CheckEmpAttendance()
        {
            //variables

            int empwage = 0;
            int empHrs = 0;

            //Computation

            Random random = new Random();
            int empCheck = random.Next(3);

            switch (empCheck)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    Console.WriteLine("Employee Is Full Time");
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    Console.WriteLine("Employee Is Part Time");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee Is Absent");
                    break;
            }
            empwage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine(" employee Wage: " + empwage);
        }
    }
   
}




   

