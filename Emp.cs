using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageN
{
    public class Emp
    {
        public const byte IS_PRESENT = 1;
        public const byte PART_PRESENT = 2;
        public const byte FULL_HRS = 8;
        public const byte PART_WORKING = 4;
        public const byte WAGE_PER_HR = 20;
        public const byte WORKING_DAYS_PER_MONTH = 20;

        public static void Welcome()
        {
            Console.WriteLine("Welcome to Employee Wage Problem");
            Console.ReadKey();
        }
        public static int CheckAttendence()
        {
            Random objectOfRandom = new Random();

            int checkAttendence = objectOfRandom.Next(0, 3);

            if (checkAttendence == IS_PRESENT)
            {
                Console.WriteLine("Employee is present");
                Console.ReadKey();
                return IS_PRESENT;
            }

            else if (checkAttendence == PART_PRESENT)
            {
                Console.WriteLine("Employee is part time Present");
                Console.ReadKey();
                return PART_PRESENT;
            }

            else
            {
                Console.WriteLine("Employee is absent");
                Console.ReadKey();
                return 0;
            }
            
        }
        public static int DailyWage()
        {
            int empHrs;

            int employeeAttendence = CheckAttendence();

            if (employeeAttendence == PART_PRESENT)
            {
                empHrs = PART_WORKING;
            }
            else if (employeeAttendence == IS_PRESENT)
            {
                empHrs = FULL_HRS;
            }
            else

                empHrs = 0;
            int dailyWage = empHrs * WAGE_PER_HR;

            Console.WriteLine("Wage for today is : " + dailyWage);
            return dailyWage;
        }
        public static int MonthlyWage()
        {
            int monthlyWage = 0;
            for(int day = 1; day<=WORKING_DAYS_PER_MONTH; day++)
            {
                int dailyWage = DailyWage();
                monthlyWage += dailyWage;
            }

            Console.WriteLine("Monthly Wage is : " + monthlyWage);
            return monthlyWage;
        }
        public static void PartTime()
        {
            int employeeAttendence = DailyWage();
        }


    }
}
