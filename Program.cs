using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Welcome To Employee Wage Computation Program************");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("**Press 0 To 'Exit' **");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("**Press 1 To  Check Employee Attendance**");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("**Press 2 To  Calculate Employee Daily Wage.**");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("**Press 3 To Check Employee Part Time Or Full Time Working And Also Calculate Wages**");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("**Press 4 To  Check Employee Daily Wage Cmputation Using Switch Case**");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("**Press 5 To Calculate Employee Wage of A Month**");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("**Press 6 To Calculate Employee Wage Till Condition MaxHrs:100,MaxDays:20**");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("**Press 7 To Calculate Employee Wage For Multiple Company**");
            Console.WriteLine("**:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::**");
            Console.WriteLine("**Press 8 To Calculate Total Employee Wage For Each Company **");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("**Press 9 To Calculate Total Employee Wage For Multiple Company **");


            Console.WriteLine("** Enter Your Choice: ***");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                    Console.WriteLine("***********Output For Employee Is Present Or Absent**************");
                    //Creating object/Instance Of Class EmployeePresence...
                    EmployeePresence objPresence = new EmployeePresence();

                    //Calling The Method/Function..
                    objPresence.CheckEmpPresence();
                    break;

                case 2:
                    Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                    Console.WriteLine("***********Output For Employee Daily Wage**************");
                    EmployeeDailyWage objEmpDailyWage = new EmployeeDailyWage();
                    objEmpDailyWage.CheckEmpDailyWage();
                    break;

                case 3:

                    Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                    Console.WriteLine("********Output For Employee Wage After Adding Part Time.*********** ");
                    EmployeeWageForPartTime objPartOrFullTime = new EmployeeWageForPartTime();
                    objPartOrFullTime.CheckEmpWagePartTime();
                    break;

                case 4:
                    Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                    Console.WriteLine("*********Output For Employee Wage Using Switch Case************");
                    EmployeeWageSwitchCase objSwitchCaseEmpWage = new EmployeeWageSwitchCase();
                    objSwitchCaseEmpWage.CheckEmpAttendance();
                    break;

                case 5:
                    Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                    Console.WriteLine("********Output For Employee Wage For Month*************");
                    EmployeeWageForMonth objEmpWageForMonth = new EmployeeWageForMonth();
                    objEmpWageForMonth.CheckEmpWageForMonth();
                    break;

                case 6:
                    Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                    Console.WriteLine("********Output For Employee Total Working Hrs Or Days In Month***********");
                    EmployeeWageHrsInMonth objEmpWageHrsInMonth = new EmployeeWageHrsInMonth();
                    objEmpWageHrsInMonth.CheckEmpWageHrsOrDayInMonth();
                    break;

                case 7:
                    Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                    Console.WriteLine("********Output For Employee Wage For Multiple Company**************");
                    EmpWageForMulCompany objEmpWageForMulCompany = new EmpWageForMulCompany();
                    objEmpWageForMulCompany.computeEmpWage("Dmart",20,2,10);
                    objEmpWageForMulCompany.computeEmpWage("Reliance", 10, 4, 20);
                    objEmpWageForMulCompany.computeEmpWage("Vodafone", 50, 5, 40);
                    objEmpWageForMulCompany.computeEmpWage("TaTa", 100, 6, 60);
                    break;

                case 8:
                    Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                    Console.WriteLine("********Output For Total Employee Wage For Each Company**************");
                    TotalWageForEachCompany dMart = new TotalWageForEachCompany("DMart",20,2,10);
                    TotalWageForEachCompany reliance = new TotalWageForEachCompany("Reliance", 10, 4, 20);
                    TotalWageForEachCompany Vodafone = new TotalWageForEachCompany("Vodafone", 50, 5, 40);
                    TotalWageForEachCompany TaTa = new TotalWageForEachCompany("Tata", 100, 8, 60);
                    dMart.computeEmpWage();
                    Console.WriteLine(dMart.toString());
                    reliance.computeEmpWage();
                    Console.WriteLine(reliance.toString());
                    Vodafone.computeEmpWage();
                    Console.WriteLine(Vodafone.toString());
                    TaTa.computeEmpWage();
                    Console.WriteLine(TaTa.toString());
                    break;
                case 9:
                    Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                    Console.WriteLine("********Output For Total Employee Wage For Multiple  Company**************");
                    EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
                    empWageBuilder.addcompanyEmpWage("Dmart", 20, 2, 10);
                    empWageBuilder.addcompanyEmpWage("Reliance", 10, 4, 20);
                    empWageBuilder.ComputeEmpWage();
                    break;

             
                  

                case 0:
                    return;

                default:
                    Console.WriteLine("**\n Please Enter Correct Choice**");
                    break;



            }
        }
    }
}


            

