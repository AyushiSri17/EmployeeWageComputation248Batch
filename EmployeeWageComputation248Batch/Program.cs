using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0;

            Console.WriteLine("Welcome to Employee Wage Computation Problem");

            //UC4 - Calculate Daily Wage Using SwitchCase
            Random random = new Random();
            int empAttendance = random.Next(0,3);
            switch (empAttendance)
            {
                case FULL_TIME:
                    Console.WriteLine("Full Time Employee is Present");
                    empHrs = 8;
                    break;
                case PART_TIME:
                    Console.WriteLine("Part Time Employee is Present");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee Wage: {0} ",empWage);
            Console.ReadLine();
        }
    }
}
