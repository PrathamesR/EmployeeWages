using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Company
    {
        int wagePerHour = 0;
        int hoursFullTime = 0;
        int hoursPartTime = 0;
        string compName = "";

        public Company(int wagePerHour,int hoursFullTime, int hoursPartTime, string companyName)
        {
            this.wagePerHour = wagePerHour;
            this.hoursFullTime = hoursFullTime;
            this.hoursPartTime = hoursPartTime;
            compName = companyName;
        }

        public void ComputeCompanyEmployeeWage()
        {
            int totalWage = 0;
            int hours = 0;
            int days = 0;
            while (days < 20 && hours < 100)
            {
                if (new Random().Next(0, 1) == 0)
                {
                    totalWage +=  this.hoursFullTime* wagePerHour;
                    days++;
                    hours += hoursFullTime;
                }
                else
                {
                    totalWage += this.hoursPartTime * wagePerHour;
                    days++;
                    hours += hoursPartTime;
                }
            }
            Console.WriteLine("Employee of " + compName + " has the salary of " + totalWage);
        }

    }
}
