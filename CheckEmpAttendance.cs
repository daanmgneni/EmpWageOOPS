using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWagev3
{
    public class CheckEmpAttendance
    {
        

        public void ComputeWage(string company,int perHrWage,int workingdays,int maxhours)

        {
            
            const int IspresentHalfTime = 2;
            const int IspresentFullTime = 1;
            const int Isabsent = 0;
            
            //int perHrWage = 0;
            int workingHrs = 0;
            int totalHrs = 0;
            //int workingdays = 0;
            //int maxhours = 0;

            Console.WriteLine($"The details for the employee in {company}");

            for (int day=1; day <= workingdays; day++)
            {
                Random rnd = new Random();
                int Attendance = rnd.Next(3);

                switch (Attendance)

                {
                    case IspresentFullTime:
                        //Console.WriteLine("Employee is present");
                        workingHrs = 8;
                        break;

                    case Isabsent:
                       // Console.WriteLine("Employee is absent");
                        workingHrs = 0;
                        break;

                    case IspresentHalfTime:
                        //Console.WriteLine("Employee is present Half-Time");
                        workingHrs = 4;
                        break;
                }

                int dayWage = perHrWage * workingHrs;
                //Console.WriteLine($"The Day Wage : {dayWage}");
                totalHrs += workingHrs;
                if (totalHrs >= maxhours) { break; }
            }
            Console.WriteLine($"\nTotal Working Hours for the Month:{totalHrs}");
            int monthlyWage= perHrWage * totalHrs;
            Console.WriteLine($"Monthly Wage for the Employee : {monthlyWage} ");
            Console.WriteLine("-----------------------------------------------");
            
        }

        
        

        
     


    }
}
