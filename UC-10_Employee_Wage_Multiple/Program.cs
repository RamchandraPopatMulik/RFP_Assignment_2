namespace UC_10_Employee_Wage_Multiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addcompanyWage("TCS",20,2,10);
            empWageBuilder.addcompanyWage("TechMahindra",10,4,20);
            empWageBuilder.computeEmpWage();
        }
    }
}