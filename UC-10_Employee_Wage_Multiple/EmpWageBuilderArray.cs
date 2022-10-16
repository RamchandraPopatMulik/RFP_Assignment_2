﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_10_Employee_Wage_Multiple
{
    public class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private int numOfCompany = 0;
        public CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addcompanyWage(String company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company,empRatePerHour,numOfWorkingDays,maxHoursPerMonth);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for(int i=0;i<numOfCompany;i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;
                        break;
                    case 2:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day: " + totalWorkingDays + "Emp Hrs : " + empHrs);

            }
            return totalEmpHrs*companyEmpWage.empRatePerHour;
        }
    }
}
