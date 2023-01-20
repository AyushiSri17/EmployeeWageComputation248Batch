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
            int isPresent = 1;
            Console.WriteLine("Welcome to EmployeeWage Computation");

            //UC1 - EmployeeAttendance
            Random random = new Random();
            //Next(maxValue) method is used , here we can use Next(minValue,maxValue) also
            int empAttendance = random.Next(2);
            Console.WriteLine(empAttendance+"\n");
            if (empAttendance == isPresent)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}
