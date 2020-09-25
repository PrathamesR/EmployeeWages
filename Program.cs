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

        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Employee Wages Problem");

            //Use Case 1
            isPresent = new Random().Next(0, 2) == 0;

            if (isPresent)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}