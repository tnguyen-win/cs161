using System;
namespace Program_6 {
    class Program {
        /*---------------
        |   IPO CHART   |
        -----------------
        |   INPUT   |
        ----------------------
        |   Get given move   |
        ----------------------
        |   PROCESSING  |
        -----------------------------------
        |   Check if given move is a tie  |
        |   Check if given move is a win  |
        |   Check if given move is a loss |
        -----------------------------------
        |   OUTPUT  |
        ---------------------------------------------------
        |   Display tie message if given move is a tie    |
        |   Display tie message if given move is a win    |
        |   Display tie message if given move is a lose   |
        -------------------------------------------------*/
        static void Main(string[] args) {
            /* Possible Combinations */
            // Rock - Paper
            // Rock - Scissors
            // Paper - Rock
            // Paper - Scissors
            // Scissors - Rock
            // Scissors - Paper
            string[] moves = { "Rock", "Paper", "Scissors" };
            /* Display Instructions */
            Console.WriteLine("Let's play a round of Rock Paper Scissors.");
            /* Get Your Move */
            Console.WriteLine("Enter | [0] for Rock | [1] for Paper | [2] for Scissors:");
            int promptYourMove = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            /* Generate And Get Computer's Move */
            Random rnd = new Random();
            int r = rnd.Next(0, 2);
            Console.WriteLine("The computer chose " + moves[r] + " while you chose " + moves[promptYourMove] + ".");
            /* Display Who Won */
            // Tie
            if (promptYourMove == r) Console.WriteLine("It's a tie. Try again.");
            // Rock - Paper OR Paper - Scissors OR Scissors - Rock
            else if ((promptYourMove == 0 && r == 1) || (promptYourMove == 1 && r == 2) || (promptYourMove == 2 && r == 1)) Console.WriteLine("You lose. Better luck next time.");
            // Rock - Scissors || Paper - Rock || Scissors - Paper
            else if ((promptYourMove == 0 && r == 2) || (promptYourMove == 1 && r == 0) || (promptYourMove == 2 && r == 0)) Console.WriteLine("You won! Congratulations.");
        }
    }
}