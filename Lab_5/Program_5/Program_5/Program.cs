using System;
namespace Program_5 {
    class Program {
        static void Game(int scorePlayer = 0, int scoreAI = 0) {
            // Check if should add newline
            if (scorePlayer != 0 || scoreAI != 0) Console.WriteLine("");
            // Display scores
            Console.WriteLine($"The current score is: {scorePlayer} versus {scoreAI}.");
            // Newline
            Console.WriteLine("");
            // Display instructions - Initial
            Console.WriteLine("Pick a number between 2-12:");
            // Get input - Number guess
            int promptNumber = int.Parse(Console.ReadLine());
            // Newline
            Console.WriteLine("");
            // Variables
            int rollsAI = 0;
            int rollsAIMax = 6;
            bool gameOver = false;
            // Roll 2 dice up to 3 times if not game over
            do {
                // Player won
                if (new Random().Next(2, 12) == promptNumber) {
                    Console.WriteLine("Congratulations! One or more of the AI rolls matched your number.");
                    scorePlayer++;
                    gameOver = true;
                    // AI won
                } else if (rollsAI == rollsAIMax - 1) {
                    Console.WriteLine("None of the AI rolls matched yours. You lose...");
                    scoreAI++;
                }
                // Update how many AI rolls have pasted
                rollsAI++;
            // Check if AI rolls have reached max length yet and not game over
            } while (rollsAI < rollsAIMax && gameOver == false);
            // Newline
            Console.WriteLine("");
            // Display instructions - Start over
            Console.WriteLine("Play another round? (Y/N)");
            // Get input - Play another round
            string promptPlayAgain = Console.ReadLine();
            // Check if yes
            if (promptPlayAgain == "y" || promptPlayAgain == "Y") Game(scorePlayer, scoreAI);
            // Check if no
            else if (promptPlayAgain == "n" || promptPlayAgain == "N") Environment.Exit(1);
        }
        static void Main() {
            // Initialize the first round
            Game();
        }
    }
}