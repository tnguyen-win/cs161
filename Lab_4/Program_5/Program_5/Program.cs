using System;
namespace Program_5 {
    /*
     * 1. Initialize moves variable.
     * 2. Initialize scorePlayer variable.
     * 3. Initialize scoreAI variable.
     * 4. Display current scores
     * 5. Display instructions.
     * 6. Get your move input.
     * 7. Generate number for A.I. move.
     * 8. Check if your move is even a valid move - if so, return types of both yours and A.I. moves.
     * 9. Check if your move is the same as the A.I. move - if so, return tie message and restart the game.
     * 10. Check if your move is weaker then the A.I. move - if so, return you lost message, increment scoreAI, and restart the game.
     * 11. Check if your move is stronger then the A.I. move - if so, return you won message, increment scorePlayer, and restart the game.
     * 12. Check if move is invalid - if so, return not valid message and restart game.
     * 13. Display greeting message and start the game initially. (Steps 1-9.)
     */
    class Program {
        static void Game(int scorePlayer = 0, int scoreAI = 0) {
            /* Variables */
            string[] moves = { "Rock", "Paper", "Scissors" };
            /* Get Your Move */
            Console.WriteLine($"The current score is: {scorePlayer} (Player) - {scoreAI} (A.I.).");
            Console.WriteLine("Enter | [0] for Rock | [1] for Paper | [2] for Scissors:");
            int promptYourMove = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            /* Generate And Get A.I. Move */
            Random rnd = new Random();
            int r = rnd.Next(0, 2);
            if (promptYourMove > 0 && promptYourMove < 2) Console.WriteLine("The computer chose " + moves[r] + " while you chose " + moves[promptYourMove] + ".");
            /* Display Who Won */
            // Tie
            if (promptYourMove == r) {
                Console.WriteLine("It's a tie. Try again.");
                Program.Game(scorePlayer, scoreAI);
            }
            // Rock - Paper OR Paper - Scissors OR Scissors - Rock
            else if ((promptYourMove == 0 && r == 1) || (promptYourMove == 1 && r == 2) || (promptYourMove == 2 && r == 1)) {
                Console.WriteLine("You lose. Better luck next time.");
                scoreAI++;
                Program.Game(scorePlayer, scoreAI);
            }
            // Rock - Scissors || Paper - Rock || Scissors - Paper
            else if ((promptYourMove == 0 && r == 2) || (promptYourMove == 1 && r == 0) || (promptYourMove == 2 && r == 0)) {
                Console.WriteLine("You won! Congratulations.");
                scorePlayer++;
                Program.Game(scorePlayer, scoreAI);
            }
            // Other
            else {
                Console.WriteLine("The number you entered was not a valid move.");
                Program.Game(scorePlayer, scoreAI);
            }
        }
        static void Main() {
            /* Display Instructions */
            Console.WriteLine("Let's play a round of Rock Paper Scissors.");
            Program.Game();
        }
    }
}