using System;
namespace Program_4 {
    /*
     * 1. Initialize moves variable.
     * 2. Display instructions.
     * 3. Get your move input
     * 4. Generate number for A.I. move.
     * 5. Check if your move is even a valid move - if so, return types of both yours and A.I. moves.
     * 6. Check if A.I. move is worst then your move - if so, return you lost message.
     * 7. Check if your move is better then the A.I. move - if so, return you won message.
     * 8. Check if move is invalid - if so, return not valid message and restart game.
     */
    class Program {
        static void Game() {
            /* Variables */
            string[] moves = { "Rock", "Paper", "Scissors" };
            /* Get Your Move */
            Console.WriteLine("Enter | [0] for Rock | [1] for Paper | [2] for Scissors:");
            int promptYourMove = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            /* Generate And Get A.I. Move */
            Random rnd = new Random();
            int r = rnd.Next(0, 2);
            if (promptYourMove > 0 && promptYourMove < 2) Console.WriteLine("The computer chose " + moves[r] + " while you chose " + moves[promptYourMove] + ".");
            /* Display Who Won */
            // Tie
            if (promptYourMove == r) Console.WriteLine("It's a tie. Try again.");
            // Rock - Paper OR Paper - Scissors OR Scissors - Rock
            else if ((promptYourMove == 0 && r == 1) || (promptYourMove == 1 && r == 2) || (promptYourMove == 2 && r == 1)) Console.WriteLine("You lose. Better luck next time.");
            // Rock - Scissors || Paper - Rock || Scissors - Paper
            else if ((promptYourMove == 0 && r == 2) || (promptYourMove == 1 && r == 0) || (promptYourMove == 2 && r == 0)) Console.WriteLine("You won! Congratulations.");
            // Other
            else {
                Console.WriteLine("The number you entered was not a valid move.");
                Program.Game();
            }
        }
        static void Main() {
            /* Display Instructions */
            Console.WriteLine("Let's play a round of Rock Paper Scissors.");
            Program.Game();
        }
    }
}