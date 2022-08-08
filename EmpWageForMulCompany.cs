using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{/// <summary>
///  Here, I Check Employee Wage For Multiple Company.
/// </summary>
    class EmpWageForMulCompany
    {
        public const int Is_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public  int computeEmpWage(string company ,int empRatePerHour,int numOFWorkingDays,int maxHoursPerMonth)
        {
            // Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //computation
            while(totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOFWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch(empCheck)
                {
                    case Is_PART_TIME:
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                     default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "EmpHrs: " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage For Company:" + company + " is:" + totalEmpWage);
            return totalEmpWage;
        }
    }
}
