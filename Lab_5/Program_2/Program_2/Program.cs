using System;
namespace Program_2 {
    class Program {
        static void Main() {
            // Display instructions - Loan
            Console.WriteLine("Enter a loan amount:");
            // Get input - Loan
            int promptLoanAmount = int.Parse(Console.ReadLine());
            // Newline
            Console.WriteLine("");
            // Display instructions - Annual interest
            Console.WriteLine("Enter an annual interest rate:");
            // Get input - Annual interest
            double promptInterestRate = double.Parse(Console.ReadLine());
            // Newline
            Console.WriteLine("");
            // Calculate - Payment
            double payment1 = (promptInterestRate * promptLoanAmount) / (1 - Math.Pow(1 + promptInterestRate, -4));
            double payment2 = (promptInterestRate * promptLoanAmount) / (1 - Math.Pow(1 + promptInterestRate, -5));
            double payment3 = (promptInterestRate * promptLoanAmount) / (1 - Math.Pow(1 + promptInterestRate, -6));
            // Calculate - Output
            Console.WriteLine($"Monthly payment for a 4 year loan: {payment1.ToString("C")}");
            Console.WriteLine($"Monthly payment for a 5 year loan: {payment2.ToString("C")}");
            Console.WriteLine($"Monthly payment for a 6 year loan: {payment3.ToString("C")}");
        }
    }
}