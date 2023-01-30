using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Program
    {
        const int FULL_TIME = 1;
        const int PART_TIME = 2;
        const int MAX_WORKING_DAYS = 20;
        const int MAX_WORKING_HRS = 100;
        const int EMP_RATE_PER_HR = 20;
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            ComputeEmployeeWage();
            Console.ReadLine();
        }
        public static void ComputeEmployeeWage()
        {    
            int empHrs = 0, empWage = 0, day = 1, totalWage = 0, totalHrs = 0;

            //UC6 - Calculate Wage Till Condition Reached
            Random random = new Random();
            while (day <= MAX_WORKING_DAYS && totalHrs <= MAX_WORKING_HRS)
            {
                int empAttendance = random.Next(0, 3);
                switch (empAttendance)
                {
                    case FULL_TIME:
                        Console.WriteLine("\nFull Time Employee is Present");
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        Console.WriteLine("\nPart Time Employee is Present");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("\nEmployee is Absent");
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HR;
                Console.WriteLine("Day {0} Employee Wage: {1}", day, empWage);
                totalWage += empWage;
                day++;
                totalHrs += empHrs;
            }
            Console.WriteLine("\nTotal Employee Wage for {0} days: {1} and total working hours {2}", (day - 1), totalWage, totalHrs);

        }
    }
}
