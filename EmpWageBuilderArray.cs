using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{/// <summary>
///  Here I Check Employee Wage For Multiple Company .
/// </summary>
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return " Total Emp Wage For Company : " + this.company + " is: " + this.totalEmpWage;
        }
    }
    public class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private int numOfcompany = 0;

        private CompanyEmpWage[] companyEmpWagesArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWagesArray = new CompanyEmpWage[5];
        }
        public void addcompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWagesArray[this.numOfcompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfcompany++;
        }
        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfcompany; i++)
            {
                companyEmpWagesArray[i].setTotalEmpWage(this.ComputeEmpWage(this.companyEmpWagesArray[i]));
                Console.WriteLine(this.companyEmpWagesArray[i].toString());
            }
        }
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalworkingDays = 0;
            //computation
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalworkingDays < companyEmpWage.numOfWorkingDays)
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
                Console.WriteLine("Day#:" + totalworkingDays + "Emp Hrs : " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }

    }
}


