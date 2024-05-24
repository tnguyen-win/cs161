using System;
namespace Program_6 {
    /*
     * 1. Initialize numGuesses variable.
     * 2. Initialize r variable.
     * 3. Display instructions.
     * 4. Get your move input and increment numGuesses.
     * 5. Check if your move's value matches the A.I. move's value - if so, return won message, also return how many guesses it took you to win, depending whether numGuesses is greater than 1 for grammatical purposes.
     * 6. Check if your move's value is greater than the A.I. move's value - if so, return too high message and restart the game.
     * 7. Check if your move's value is lesser than the A.I. move's value - if so, return too low message and restart the game.
     * 9. Generate and get A.I. move's value.
     * 10. Start the game initially. (Steps 1-9.)
     */
    class Program {
        static void Game(int numGuesses, int r) {
            /* Get Your Move */
            Console.WriteLine("Enter a guess for the A.I. generated number:");
            int promptYourMove = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            /* Increment Current Guesses */
            numGuesses++;
            // Guess is a exact match
            if (promptYourMove == r) {
                Console.WriteLine("Your guess was correct. Congratulations!!!");
                if (numGuesses == 1) Console.WriteLine($"It only took you {numGuesses} try to guess the right answer.");
                else Console.WriteLine($"It took you {numGuesses} tries to guess the right answer.");
            }
            // Guess too high
            else if (promptYourMove > r) {
                Console.WriteLine("Your guess is too high. Try again.");
                Program.Game(numGuesses, r);
            }
            // Guess too low
            else if (promptYourMove < r) {
                Console.WriteLine("Your guess is too low. Try again.");
                Program.Game(numGuesses, r);
            }
        }
        static void Main() {
            /* Generate And Get A.I. Move */
            Random rnd = new Random();
            int r = rnd.Next(1, 50);
            /* Init */
            Program.Game(0, r);
        }
    }
}