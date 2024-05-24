using System;
namespace Program_4 {
    class Program {
        /*---------------
        |   IPO CHART   |
        -----------------
        |   INPUT   |
        -------------------------------------
        |   Get given first primary color   |
        |   Get given second primary color  |
        -------------------------------------
        |   PROCESSING  |
        --------------------------------------------------------------------------------------
        |   Check if given first and second given primary colors match specific combinations |
        --------------------------------------------------------------------------------------
        |   OUTPUT  |
        -------------------------------------------------------------------------------------------------------------------------------------
        |   Display color message if given primary colors match a specific color combination, else display not a color combination message  |
        -----------------------------------------------------------------------------------------------------------------------------------*/
        static void Main(string[] args) {
            // Display Instructions
            Console.Write("Choose at least two of these primary colors, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Red");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(", ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Yellow");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(", or ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Blue");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(".");
            Console.WriteLine("");
            // Get First Color Choice
            Console.WriteLine("Enter your first primary color choice:");
            string promptColor1 = Console.ReadLine();
            Console.WriteLine("");
            // Get Second Color Choice
            Console.WriteLine("Now enter your second primary color choice:");
            string promptColor2 = Console.ReadLine();
            Console.WriteLine("");
            // Display Color Combinations
            // Red (Orange + Purple)
            if (promptColor1 == "Red" || promptColor2 == "Red") {
                // Orange
                if (promptColor1 == "Yellow" || promptColor2 == "Yellow") {
                    Console.Write("The mixed color that these two primary colors produce is Orange.");
                    Console.WriteLine("");
                }
                // Purple
                if (promptColor1 == "Blue" || promptColor2 == "Blue") {
                    Console.Write("The mixed color that these two primary colors produce is Purple.");
                    Console.WriteLine("");
                }
            }
            // Yellow (Green)
            if (promptColor1 == "Yellow" || promptColor2 == "Yellow") {
                // Blue
                if (promptColor1 == "Blue" || promptColor2 == "Blue") {
                    Console.Write("The mixed color that these two primary colors produce is Green.");
                    Console.WriteLine("");
                }
            }
        }
    }
}