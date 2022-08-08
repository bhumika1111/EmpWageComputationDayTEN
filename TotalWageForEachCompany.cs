using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{ /// <summary>
///  Here I Check Total Employee Wage For Each Company.
/// </summary>
  public  class TotalWageForEachCompany
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private String company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public TotalWageForEachCompany(string company , int empRatePerHour,int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
        {
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalworkingDays = 0;
            //computation
            while(totalEmpHrs <= this.maxHoursPerMonth && totalworkingDays < this.maxHoursPerMonth && totalworkingDays < this.numOfWorkingDays)
            {
                totalworkingDays++;
                Random random = new Random();
                int empCheck = random.Next(3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
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
                Console.WriteLine("Day#:" + totalworkingDays + "Emp Hrs : "  +  empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage For Company : " + company + " is: " + totalEmpWage);
        }
        public string toString()
        {
            return " Total Emp Wage For Company :" + this.company + " is: " + this.totalEmpWage;
        }
    }
}
