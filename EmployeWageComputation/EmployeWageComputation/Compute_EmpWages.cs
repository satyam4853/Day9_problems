using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeWageComputation
{
    class EmployeeClass
    {
        public string Company;
        public int WagePerHour;
        public int MaxHoursPerMonth;
        public int MaxWorkingDays;
        public void CompanyEmpWage(string company, int wagePerHour, int maxHoursPerMonth, int maxWorkingDays)
        {
            Company = company;
            WagePerHour = wagePerHour;
            MaxHoursPerMonth = maxHoursPerMonth;
            MaxWorkingDays = maxWorkingDays;

            int empHours = 0;
            int empDailyWage = 0;
            int workingDays = 0;
            int workingHrs = 0;
            int totalWage = 0;

            Random rand = new Random();

            while (workingDays <= MaxWorkingDays && workingHrs <= MaxHoursPerMonth)
            {
                int number = rand.Next(0, 3);
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Employee is present for full-time");
                        empHours = 8;
                        workingDays++;
                        break;
                    case 2:
                        Console.WriteLine("Employee is present for part-time");
                        empHours = 4;
                        workingDays++;
                        break;
                    default:
                        Console.WriteLine("Employee is absent");
                        break;

                }
                empDailyWage = empHours * WagePerHour;
                totalWage += empDailyWage;
                workingHrs += empHours;

            }
            Console.WriteLine("Company Name:" + Company);
            Console.WriteLine("Employee Working Hours :" + workingHrs);
            Console.WriteLine("Employee Wage Per day :" + empDailyWage);
            Console.WriteLine("Employee Working days in month :" + workingDays);
            Console.WriteLine("Employee Wage for working days :" + totalWage);

        }
    }
}