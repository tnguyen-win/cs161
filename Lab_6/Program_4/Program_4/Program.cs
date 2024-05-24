using System;
namespace Program_4 {
    class Program {
        static void Game(bool init = false) {
            // Check - If newline
            if (!init) Console.WriteLine("");
            // Display - Instructions
            Console.Write("Enter a question: ");
            // Newline
            Console.WriteLine("");
            // Generate - Random number
            //int[] replies = new [20];
            int rdn = new Random().Next(0, 20);
            int[] anArray = [];
            // Check - Question reply
            Console.WriteLine(anArray[rdn]);
            // responces[8] = "Yes.";
            // Newline
            Console.WriteLine("");
            // Display - Play again
            Console.Write("Play again? (Y/N):");
            // Get input - Reply
            string promptReply = Console.ReadLine();
            // Check - Reply yes or no
            if (promptReply == "y" || promptReply == "Y") Game();
        }
        static void Main() {
            // Run - Initialize
            Game(true);
        }
    }
}