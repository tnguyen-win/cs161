using System;
namespace Program_3 {
    class Program {
        static void Game(int round = 0) {
            // Variables
            int num = 0;
            // Check if should add newline
            if (round > 0) Console.WriteLine("");
            // Display instructions - Initial
            Console.WriteLine("Enter a prime number:");
            // Get input - Potential prime number
            int promptPerfectNumber = int.Parse(Console.ReadLine());
            // Newline
            Console.WriteLine("");
            // Calculate numbers
            for (int i = 1; i <= promptPerfectNumber; i++) if (promptPerfectNumber % i == 0) num++;
            // Check if your guess is a potential perfect number
            if (num == 2) Console.WriteLine("Correct! The number you picked is a prime number.");
            // Check if your guess is not a potential perfect number
            else Console.WriteLine("Incorrect... The number you picked is not a prime number.");
            // Newline
            Console.WriteLine("");
            // Display instructions - Start over
            Console.WriteLine("Do you want to check another number? (Y/N.)");
            // Get input - Yes or no
            string promptPlayAgain = Console.ReadLine();
            // Get if yes
            if (promptPlayAgain == "y" || promptPlayAgain == "Y") {
                round++;
                Game(round);
            }
            // Get if no
            else if (promptPlayAgain == "n" || promptPlayAgain == "N") Environment.Exit(1);
        }
        static void Main() {
            Game();
        }
    }
}