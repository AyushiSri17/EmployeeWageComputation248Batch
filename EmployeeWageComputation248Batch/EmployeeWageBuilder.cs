using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWageBuilder
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        //const int MAX_WORKING_DAYS = 20;
        //const int MAX_WORKING_HRS = 100;
        //const int EMP_RATE_PER_HR = 20;
        public string company;
        public int maxWorkingDays, maxWorkingHrs, empRatePerHr;

        //constructor
        public EmployeeWageBuilder(string company, int maxWorkingDays, int maxWorkingHrs, int empRatePerHr)
        {
            this.company = company;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs= maxWorkingHrs;
            this.empRatePerHr = empRatePerHr;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");

            EmployeeWageBuilder deloitte = new EmployeeWageBuilder("BridgeLabz", 20, 100, 35);
            deloitte.ComputeEmployeeWage();
            EmployeeWageBuilder bridge = new EmployeeWageBuilder("Google", 24, 45, 30);
            bridge.ComputeEmployeeWage();
            EmployeeWageBuilder google = new EmployeeWageBuilder("MicroSoft", 18, 55, 40);
            google.ComputeEmployeeWage();
            
            Console.ReadLine();
        }
        public void ComputeEmployeeWage()
        {    
            int empHrs = 0, empWage = 0, day = 1, totalWage = 0, totalHrs = 0;

            //UC6 - Calculate Wage Till Condition Reached
            Random random = new Random();
            while (day <= maxWorkingDays && totalHrs <= maxWorkingHrs)
            {
                int empAttendance = random.Next(0, 3);
                switch (empAttendance)
                {
                    case FULL_TIME:
                        //Console.WriteLine("\nFull Time Employee is Present");
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        //Console.WriteLine("\nPart Time Employee is Present");
                        empHrs = 4;
                        break;
                    default:
                        //Console.WriteLine("\nEmployee is Absent");
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * empRatePerHr;
                //Console.WriteLine("Day {0} Employee Wage: {1}", day, empWage);
                totalWage += empWage;
                day++;
                totalHrs += empHrs;
            }
            Console.WriteLine("\nTotal Employee Wage for {3} {0} days: is {1} and total working hours {2}", (day - 1), totalWage, totalHrs, company);

        }
    }
}
