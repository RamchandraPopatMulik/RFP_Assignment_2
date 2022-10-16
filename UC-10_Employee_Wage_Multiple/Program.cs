namespace UC_10_Employee_Wage_Multiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray tcs = new EmpWageBuilderArray("TCS", 20, 20, 100);
            EmpWageBuilderArray Tech = new EmpWageBuilderArray("TechMahindra", 20, 20, 100);
            tcs.computeEmpWage();
            Tech.computeEmpWage();
           
        }
    }
}