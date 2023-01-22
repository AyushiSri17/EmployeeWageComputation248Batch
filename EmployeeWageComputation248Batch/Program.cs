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
            //UC3 - Calculating Daily Wage and part time wage
            Random random = new Random();
            int empAttendance = random.Next(0,3);
            if (empAttendance == FULL_TIME)
            {
                Console.WriteLine("Full Time Employee is present");
                empHrs = 8;
            }
            else if (empAttendance == PART_TIME)
            {
                Console.WriteLine("Part Time Employee is present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee Wage:{0}", empWage);
            Console.ReadLine();
        }
    }
}
