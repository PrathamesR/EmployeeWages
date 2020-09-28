using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeWageProblem;

namespace EmployeeWageProblem
{
    class CompanyManager
    {
        private List<Company> companyList = new List<Company>();

        public void AddCompany(Company company)
        {
            companyList.Add(company);
        }

        public void ListCompanies()
        {
            foreach (Company comp in companyList)
            {
                Console.WriteLine("The company " + comp.GetName() + " has the total Wage : " + comp.GetTotalWage());
            }
        }
    }
}
