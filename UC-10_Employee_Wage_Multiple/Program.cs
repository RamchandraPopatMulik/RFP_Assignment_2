namespace UC_10_Employee_Wage_Multiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Company Name:");
            string company = Console.ReadLine();

            Console.WriteLine("Please Enter Employee Rate Per Hour :");
            int empRatePerHr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Number Of Working Days :");
            int numOfWorkingDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Maximum Hours Per Month :");
            int maxHoursPerMonth = Convert.ToInt32(Console.ReadLine());


            EmpWageBuilderArray tcs = new EmpWageBuilderArray(company,empRatePerHr,numOfWorkingDays,maxHoursPerMonth);
            
            tcs.computeEmpWage();
            
           
        }
    }
}