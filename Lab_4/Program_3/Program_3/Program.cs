using System;
namespace Program_3 {
    /*
     * 1. Initialize num variable.
     * 2. Display instructions.
     * 3. Get prime number input.
     * 4. Calculate divisible and add to num if is.
     * 5. Check if num matches 2 - return YES or NO messages.
     */
    class Program {
        static void Main() {
            /* Variables */
            int num = 0;
            /* Display instructions */
            Console.WriteLine("Enter a non-zero positive number:");
            /* Get Potential Prime Number */
            int promptPerfectNumber = int.Parse(Console.ReadLine());
            /* Calculate Potential Perfect Number Sum */
            for (int i = 1; i <= promptPerfectNumber; i++) if (promptPerfectNumber % i == 0) num++;
            /* Check - Yes */
            if (num == 2) Console.WriteLine("True. The number you picked is a prime number!");
            /* Check - No */
            else Console.WriteLine("False. The number you picked is not a prime number...");
        }
    }
}