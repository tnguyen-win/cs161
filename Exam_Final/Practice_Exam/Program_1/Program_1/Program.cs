/*
    Assume that you've been asked to write an application that allows the user to play a simple dice game.
    The game begins by allowing the user to pick a number between 2 and 12 (the possible sum of 2 dice).
    The computer will then roll 2 dice up to 3 times.
    If the number chosen by the user comes up, the user wins and the game ends.
    If the number does not come up within 3 tries, the computer wins.
    The user should be able to play the game as many times as he/she/they want and the application should keep track of the cumulative score for both the user and the computer.
    Any input from the user should be validated in a reasonable way.

    Create a structure chart that identifies the methods that you would create to solve this problem as well as the parameters and return values for each method.
    You may sketch your structure chart on a piece of paper or create the chart using a drawing tool like Visio or Draw.io.
    You may also create a list of each method that you would create.
    Make sure that the list includes a brief description of the purpose of the method as well as its parameters and return value. 
    Create an algorithm in pseudocode for the Main method only.
    Upload a file that contains both your structure chart (or list) and your pseudocode in moodle.
*/
using System;
namespace Program_1 {
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
                }
                else if (rollsAI == rollsAIMax - 1) {
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