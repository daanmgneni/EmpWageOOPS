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
            int Ispresent = 1;
            int perHrWage = 20;
            int workingHrs = 0;
            Random rnd = new Random();
            int Attendance=rnd.Next();

            if ( Attendance == Ispresent )
            {
                Console.WriteLine("Employee is present");
                workingHrs = 8;

            }
            else
            {
                Console.WriteLine("Employee is absent");
                workingHrs = 0;
            }
            int dayWage = perHrWage * workingHrs;
            Console.WriteLine($"The Day Wage : {dayWage}");

        }

        
        

        
     


    }
}
