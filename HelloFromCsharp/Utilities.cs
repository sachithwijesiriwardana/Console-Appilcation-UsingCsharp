using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HelloFromCsharp
{
    internal class Utilities

    {
        //String Equlity 
        public static void UsingStringEquality()
        {
            string firstName = "sachith1";
            string lastName = "Sachith1";
            Console.WriteLine((firstName== lastName));



        }
        public static void UsingEscapeCharacters()
        {
            string firstName = "sachith1";
            string lastName = "wijesiriwardana1";

            string displayName = $"Welcome!\n{firstName}\t{lastName}";
            Console.WriteLine(displayName);
           
           

        }

        //Using String Catination And Other Method in String 
        public static void ManipulatingStrings()

{
        string firstName = "sachith1";
        string lastName = "wijesiriwardana1";
        string fullName = firstName + " " + lastName;
        string employeeIdentification = String.Concat(firstName, lastName);

            string empId =firstName.ToLower();

            int length = empId.Length;

            Console.WriteLine(employeeIdentification + " " + length);


}
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


//string upper = myString.ToUpper();
//string lower = myString.ToLower();

//We can Concaternater String Also 
//Assign 2 Stringd and using buy adding 

//String.Concat(s1,s2)