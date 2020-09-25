﻿using System;
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
            Console.WriteLine("Daily Employee Wage is " + wagePerHour * fullDayHour);
        }
    }
}