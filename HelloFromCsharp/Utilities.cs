using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFromCsharp
{
    internal class Utilities
    {
        public static void UsingOptionalParameters()
        {
            int monthlywage = 1234;
            int months1 = 12;

            int yesrlyWageForEmployee1 = CalculateYearlyWageWithOptional(monthlyWage: monthlywage,
    numberOfMonthsWorked: months1);
            Console.WriteLine(yesrlyWageForEmployee1);

        }
        public static int CalculateYearlyWageWithOptional(int monthlyWage, int numberOfMonthsWorked,int bonus=0 )
        {
            //Console.WriteLine($"Yearly wage : {monthlyWage * numberOfMonthsWorked}");
            // return monthlyWage * numberOfMonthsWorked;
            if (numberOfMonthsWorked == 12)
                return monthlyWage * (numberOfMonthsWorked + 1);
            return monthlyWage * numberOfMonthsWorked;
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked ,int bonus)
        {
            Console.WriteLine($"Yearly wage : {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

    }
}
