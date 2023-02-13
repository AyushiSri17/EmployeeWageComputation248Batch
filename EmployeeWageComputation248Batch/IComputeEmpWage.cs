using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation248Batch
{
    public interface IComputeEmpWage
    {
        void AddCompanyDetails(string company, int maxWorkingDays, int maxWorkingHrs, int empRatePerHr);

        void IterateOverCompanies();

        void GetTotalWageOnCompany(string comp);
    }
}
