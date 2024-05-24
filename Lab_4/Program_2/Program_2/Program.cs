using System;
namespace Program_2 {
    /*
     * 1. Initialize sum variable.
     * 2. Display instructions.
     * 3. Get perfect number input.
     * 4. Calculate divisible and add to sum if is and if number between is between 1 or 1000.
     * 5. Check if sum matches given perfect number - return YES or NO messages.
     */
    class Program {
        static void Main() {
            /* Variables */
            int sum = 0;
            /* Display Instructions */
            Console.WriteLine("Enter a perfect number:");
            /* Get Potential Perfect Number */
            int promptPerfectNumber = int.Parse(Console.ReadLine());
            /* Calculate Potential Perfect Number Sum */
            // TIP: Try 8128 for a perfect number that is greater than 1000
            for (int i = 1; i < promptPerfectNumber; i++) if (promptPerfectNumber % i == 0 && i >= 1 && i <= 1000) sum += i;
            /* Check - Yes */
            if (promptPerfectNumber == sum) Console.WriteLine("The number you picked is a perfect number!");
            /* Check - No */
            else Console.WriteLine("The number you picked is not a perfect number...");
        }
    }
}