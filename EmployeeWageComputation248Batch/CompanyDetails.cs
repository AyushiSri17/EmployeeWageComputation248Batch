using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation248Batch
{
    public class CompanyDetails
    {
        public string company;
        public int maxWorkingDays, maxWorkingHrs, empRatePerHr, totalWage;

        public CompanyDetails(string company, int maxWorkingDays, int maxWorkingHrs, int empRatePerHr)
        {
            this.company = company;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
            this.empRatePerHr = empRatePerHr;
        }
        public void SetTotalWage(int totalWage)
        {
            this.totalWage = totalWage;
        }
        public override string ToString()
        {
            return $"Company:{company} TotalWage:{totalWage}";
        }
    }
}
