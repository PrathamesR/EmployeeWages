using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeWageProblem;

namespace EmployeeWages
{
    class Program
    {
        static bool isPresent;
        static int wagePerHour;
        static int fullDayHour;
        static int partTimeHour;
        static int daysOfMonth;
        static int hoursWorked;

        static int ComputeEmployeeWage()
        {
            hoursWorked = 100;
            Console.WriteLine("The Wage is " + CalculateWageByHour(wagePerHour, hoursWorked));

            int totalWage = 0;
            int hours = 0;
            int days = 0;
            while (days < 20 && hours < 100)
            {
                if (new Random().Next(0, 1) == 0)
                {
                    totalWage += CalculateDailyWage(fullDayHour, partTimeHour);
                    days++;
                    hours += fullDayHour;
                }
                else
                {
                    totalWage += CalculateDailyWage(partTimeHour, partTimeHour);
                    days++;
                    hours += partTimeHour;
                }
            }
            return totalWage;

        }

        static void ComputeCompanyEmployeeWage(string compName, int hoursFull,int hoursPartTime, int wagePerHour)
        {
            hoursWorked = 100;
            int totalWage = 0;
            int hours = 0;
            int days = 0;
            while (days < 20 && hours < 100)
            {
                if (new Random().Next(0, 1) == 0)
                {
                    totalWage += CalculateDailyWage(hoursFull, wagePerHour);
                    days++;
                    hours += fullDayHour;
                }
                else
                {
                    totalWage += CalculateDailyWage(hoursFull, wagePerHour);
                    days++;
                    hours += partTimeHour;
                }
            }
            Console.WriteLine("Employee of " + compName + " has the salary of " + totalWage);
        }

        static int CalculateDailyWage(int a, int b)
        {
            return a * b;
        }

        static int CalculateMontlyWage(int a, int b, int days)
        {
            return CalculateDailyWage(a,b) * days;
        }

        static int CalculateWageByHour(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Employee Wages Problem");

            //Use Case 1
            isPresent = new Random().Next(0, 2) == 1;

            if (isPresent)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");

            //Use Case 2
            wagePerHour = 20;
            fullDayHour = 8;
            Console.WriteLine("Daily Employee Wage is " + CalculateDailyWage(wagePerHour, fullDayHour));

            //Use Case 3
            partTimeHour = 8;
            Console.WriteLine("Part Time Employee Wage is " + CalculateDailyWage(wagePerHour, partTimeHour));

            //Use Case 4
            Console.WriteLine("Select \n1. Part Time \n2. Full Time");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Daily Employee Wage is " + CalculateDailyWage(wagePerHour, fullDayHour));
                    break;
                case 2:
                    Console.WriteLine("Part Time Employee Wage is " + CalculateDailyWage(wagePerHour, partTimeHour));
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }

            //Use Case 5
            daysOfMonth = 20;
            Console.WriteLine("The Monthly Wage is " + CalculateMontlyWage(wagePerHour,fullDayHour,daysOfMonth));

            //Use Case 6 + Use Case 7 Refractor            
            Console.WriteLine("The Employee Wage is " + ComputeEmployeeWage());


            //Use Case 8
            Console.WriteLine("\nEnter Company Name");
            string compName = Console.ReadLine();
            ComputeCompanyEmployeeWage(compName,8,4,200);

            Console.WriteLine("\nEnter Company Name");
            compName = Console.ReadLine();
            ComputeCompanyEmployeeWage(compName, 7, 3, 200);

            //Use Case 9
            Company comp1 = new Company(100, 8, 4, "ABC");
            comp1.ComputeCompanyEmployeeWage();

            //Use Case 10
            Company comp2 = new Company(200, 10, 3, "BCD");
            Company comp3 = new Company(150, 9, 4, "EFG");

            CompanyManager companyManager = new CompanyManager();

            companyManager.AddCompany(comp1);
            companyManager.AddCompany(comp2);
            companyManager.AddCompany(comp3);

            Console.WriteLine();
            companyManager.ListCompanies();

            //Use Case 14
            Console.Write(comp1.GetDailyWage());

            Console.ReadLine();
        }
    }
}