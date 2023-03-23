using EmpWagev3;

namespace OOPS
{
    class EmpWage
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            CheckEmpAttendance emp = new CheckEmpAttendance();
            emp.ComputeWage("TCS",200,20,100);
            emp.ComputeWage("Infosys",250,24,120);
        }
    }
}
