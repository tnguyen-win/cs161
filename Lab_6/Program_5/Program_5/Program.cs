using System;
/*
 * Design and implement a program that simulates a lottery.
 * The user should be asked to enter 5 integers between 1 and 69 and an additional integer between 1 and 26.
 * The computer will generate random numbers, 5 between 1 and 69 and 1 between 1 and 26, for the winning lottery ticket.
 * The program should display the winning lottery ticket as well as the user's results.
 * The image at the right gives the possible prizes.
 */
namespace Program_5 {
    class Program {
        static void Main() {
            // Variables
            int yourGuess1 = -1;
            int yourGuess2 = -1;
            int yourGuess3 = -1;
            int yourGuess4 = -1;
            int yourGuess5 = -1;
            int yourGuess6 = -1;
            int aiGuess1 = -1;
            int aiGuess2 = -1;
            int aiGuess3 = -1;
            int aiGuess4 = -1;
            int aiGuess5 = -1;
            int aiGuess6 = -1;
            int matchTotal = -1;
            // Your - Guess 1
            Console.Write("Enter a number between 1-69: ");
            yourGuess1 = int.Parse(Console.ReadLine());
            // Your - Guess 2
            Console.Write("Enter a number between 1-69: ");
            yourGuess2 = int.Parse(Console.ReadLine());
            // Your - Guess 3
            Console.Write("Enter a number between 1-69: ");
            yourGuess3 = int.Parse(Console.ReadLine());
            // Your - Guess 4
            Console.Write("Enter a number between 1-69: ");
            yourGuess4 = int.Parse(Console.ReadLine());
            // Your - Guess 5
            Console.Write("Enter a number between 1-69: ");
            yourGuess5 = int.Parse(Console.ReadLine());
            // Your - Guess 6
            Console.Write("Enter a number between 1-26: ");
            yourGuess6 = int.Parse(Console.ReadLine());
            // AI - Guess 1
            aiGuess1 = new Random().Next(1, 69);
            // AI - Guess 2
            aiGuess2 = new Random().Next(1, 69);
            // AI - Guess 3
            aiGuess3 = new Random().Next(1, 69);
            // AI - Guess 4
            aiGuess4 = new Random().Next(1, 69);
            // AI - Guess 5
            aiGuess5 = new Random().Next(1, 69);
            // AI - Guess 6
            aiGuess6 = new Random().Next(1, 26);
            // Calculate - How many matches
            int[] all_your_guesses = {yourGuess1, yourGuess2, yourGuess3, yourGuess4, yourGuess5, yourGuess6};
            int[] all_ai_guesses = {aiGuess1, aiGuess2, aiGuess3, aiGuess4, yourGuess5, yourGuess6};
            for (int i1 = 0; i1 < all_your_guesses.Length; i1++) {
                for (int i2 = 0; i2 < all_ai_guesses.Length; i2++) {
                    if (all_your_guesses[i1] == all_ai_guesses[i2]) {
                        Console.WriteLine($"i1: {all_your_guesses[i1]}");
                        Console.WriteLine($"i2: {all_ai_guesses[i2]}");
                        matchTotal++;
                    }
                }
                break;
            }
            // Display - Final output
            Console.WriteLine("");
            Console.WriteLine($"Your numbers: {yourGuess1}, {yourGuess2}, {yourGuess3}, {yourGuess4}, {yourGuess5}, {yourGuess6}.");
            Console.WriteLine($"AI numbers: {aiGuess1}, {aiGuess2}, {aiGuess3}, {aiGuess4}, {aiGuess5}, {aiGuess6}.");
            Console.WriteLine($"Total found matches: {matchTotal}.");
        }
    }
}