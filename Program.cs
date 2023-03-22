using EmpWagev3;

namespace OOPS
{
    class EmpWage
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            CheckEmpAttendance obj= new CheckEmpAttendance();
            obj.EmpCheck();
        }
    }
}
