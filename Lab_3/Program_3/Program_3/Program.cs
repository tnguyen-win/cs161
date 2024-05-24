using System;
using System.Text;
namespace Program_3 {
    class Program {
        /*---------------
        |   IPO CHART   |
        -----------------
        |   INPUT   |
        ----------------------------
        |   Get possible solution  |
        ----------------------------
        |   PROCESSING  |
        ------------------------------------------------------
        |   Check if given solution matches actual solution  |
        ------------------------------------------------------
        |   OUTPUT  |
        ----------------------------------------------------------------------------------------------------------------
        |   Display message depending on whether given solution is correct, else display incorrect solution message    |
        ---------------------------------------------------------------------------------------------------------------*/
        static void Main(string[] args) {
            /* Generate Two Random Numbers */
            Random rnd = new Random();
            int r1 = rnd.Next(10, 999);
            int r2 = rnd.Next(10, 999);
            /* Display The Random Numbers */
            Console.WriteLine($"What is ({r1} + {r2})?");
            /* Get Possible Solution From User */
            string promptSolution1 = Console.ReadLine();
            promptSolution1.Replace("$", "");
            promptSolution1.Replace(",", "");
            int promptSolution2 = int.Parse(promptSolution1, System.Globalization.NumberStyles.Any);
            /* Check If Total Correct */
            Console.OutputEncoding = Encoding.UTF8;
            if (promptSolution2 == (r1 + r2)) Console.WriteLine("Correct answer!🙂");
            else Console.WriteLine("Incorrect answer.🙁The actual solution is " + (r1 + r2) + ".");
        }
    }
}