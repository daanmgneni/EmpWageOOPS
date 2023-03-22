using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWagev3
{
    public class Emp
    {
        

        public int EmpMonthlyWage()
        {
            
            const int IspresentHalfTime = 2;
            const int IspresentFullTime = 1;
            const int Isabsent = 0;
            
            int perHrWage = 20;
            int workingHrs = 0;
            int totalHrs = 0;   

            

            for (int day=1; day <= 20; day++)
            {
                Random rnd = new Random();
                int Attendance = rnd.Next(3);

                switch (Attendance)

                {
                    case IspresentFullTime:
                        Console.WriteLine("Employee is present");
                        workingHrs = 8;
                        break;

                    case Isabsent:
                        Console.WriteLine("Employee is absent");
                        workingHrs = 0;
                        break;

                    case IspresentHalfTime:
                        Console.WriteLine("Employee is present Half-Time");
                        workingHrs = 4;
                        break;
                }

                int dayWage = perHrWage * workingHrs;
                Console.WriteLine($"The Day Wage : {dayWage}");
                totalHrs += workingHrs;
                if (totalHrs >= 100) { break; }
            }
            Console.WriteLine($"\nTotal Working Hours for the Month:{totalHrs}");
            int monthlyWage= perHrWage * totalHrs;
            Console.WriteLine($"Monthly Wage for the Employee : {monthlyWage} ");
            return monthlyWage;
        }

        
        

        
     


    }
}
