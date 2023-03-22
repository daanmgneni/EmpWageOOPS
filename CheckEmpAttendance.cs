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
            Random rnd = new Random();
            int Attendance=rnd.Next();

            if ( Attendance == Ispresent )
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }

        
        

        
     


    }
}
