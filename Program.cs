using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    class Program
    {
        static bool isPresent;
        static int wagePerHour;
        static int fullDayHour;
        static int partTimeHour;
        static int daysOfMonth;

        static int CalculateDailyWage(int a, int b)
        {
            return a * b;
        }

        static int CalculateMontlyWage(int a, int b, int days)
        {
            return CalculateDailyWage(a,b) * days;
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
        }
    }
}