using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWagev3
{
    public class CheckEmpAttendance
    {
        

        public void EmpCheck()
        {
            
            int IspresentHalfTime = 2;
            int IspresentFullTime = 1;
            int Isabsent = 0;
            
            int perHrWage = 20;
            int workingHrs = 0;
            Random rnd = new Random();
            int Attendance=rnd.Next(3);

            if ( Attendance == IspresentFullTime )
            {
                Console.WriteLine("Employee is present");
                workingHrs = 8;

            }
            else if  ( Attendance == Isabsent )
            {
                Console.WriteLine("Employee is absent");
                workingHrs = 0;
            }
            else if ( Attendance == IspresentHalfTime )
            {
                Console.WriteLine("Employee is present Half-Time");
                workingHrs = 4;
            }

            int dayWage = perHrWage * workingHrs;
            Console.WriteLine($"The Day Wage : {dayWage}");

        }

        
        

        
     


    }
}
