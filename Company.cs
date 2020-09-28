using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Company
    {
        private int wagePerHour = 0;
        private int hoursFullTime = 0;
        private int hoursPartTime = 0;
        private string compName = "";
        private int totalWage;

        public Company(int wagePerHour,int hoursFullTime, int hoursPartTime, string companyName)
        {
            this.wagePerHour = wagePerHour;
            this.hoursFullTime = hoursFullTime;
            this.hoursPartTime = hoursPartTime;
            compName = companyName;

            ComputeCompanyEmployeeWage();
        }

        public int GetTotalWage()
        {
            return totalWage;
        }

        public string GetName()
        {
            return compName;
        }

        public void ComputeCompanyEmployeeWage()
        {
            totalWage = 0;
            int hours = 0;
            int days = 0;
            while (days < 20 && hours < 100)
            {
                if (new Random().Next(0, 1) == 0)
                {
                    totalWage +=  hoursFullTime* wagePerHour;
                    days++;
                    hours += hoursFullTime;
                }
                else
                {
                    totalWage += hoursPartTime * wagePerHour;
                    days++;
                    hours += hoursPartTime;
                }
            }
        }

    }
}
