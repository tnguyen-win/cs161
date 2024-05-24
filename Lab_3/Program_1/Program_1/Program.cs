using System;
using System.Text;
namespace Program_1 {
    class Program {
        /*---------------
        |   IPO CHART   |
        -----------------
        |   INPUT   |
        -----------------
        |   Get salary  |
        |   Get tenure  |
        -----------------
        |   PROCESSING  |
        ---------------------------------------------------------------------------------------------------------
        |   Check whether BOTH given SALARY and TENURE is greater than, or equal to the minimum requirements    |
        ---------------------------------------------------------------------------------------------------------
        |   OUTPUT  |
        ---------------------------------------------------------------------
        |   Display Yes or No messages depending on minimum requirements    |
        -------------------------------------------------------------------*/
        static void Main(string[] args) {
            int minSalary = 40000;
            int minTenure = 1;
            // Get Salary
            Console.WriteLine("Enter how much you earn in a year:");
            Console.Write("$");
            string promptSalary1 = Console.ReadLine();
            // Remove Money Symbol + Comma If Existing
            promptSalary1.Replace("$", "");
            promptSalary1.Replace(",", "");
            // Try To Convert String To Int
            int promptSalary2 = int.Parse(promptSalary1, System.Globalization.NumberStyles.Any);
            // Get Tenure
            Console.WriteLine("Enter how many years you've held your job:");
            int promptJobTenure = int.Parse(Console.ReadLine());
            // Emojis Hack
            Console.OutputEncoding = Encoding.UTF8;
            // Check Conditions
            if ((promptSalary2 >= minSalary) && (promptJobTenure >= minTenure)) Console.WriteLine("✅ Great! You're eligible for a loan.");
            else Console.WriteLine("❌ Unfortunately, you don't seem to be eligible for a loan at this time. Perhaps in the future you can.");
        }
    }
}