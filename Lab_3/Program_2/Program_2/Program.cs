using System;
namespace Program_2 {
    class Program {
        /*---------------
        |   IPO CHART   |
        -----------------
        |   INPUT   |
        ------------------------
        |   Get ROMAN NUMERAL  |
        ------------------------
        |   PROCESSING  |
        ---------------------------------------------------------------
        |   Check if given ROMAN NUMERAL equals I, II, III, IV, or V  |
        ---------------------------------------------------------------
        |   OUTPUT  |
        --------------------------------------------------------------------------------------------------------------------
        |   Display value of given ROMAN NUMERAL. If given value is not interpretable, display instead an error message    |
        ------------------------------------------------------------------------------------------------------------------*/
        static void Main(string[] args) {
            Console.WriteLine("Enter a Roman numeral:");
            string promptRomanNumeral = Console.ReadLine();
            string stringTemplate = "This Roman numeral's decimal number is: ";
            switch (promptRomanNumeral) {
                case "I":
                    Console.WriteLine(stringTemplate + 1);
                    break;
                case "II":
                    Console.WriteLine(stringTemplate + 2);
                    break;
                case "III":
                    Console.WriteLine(stringTemplate + 3);
                    break;
                case "IV":
                    Console.WriteLine(stringTemplate + 4);
                    break;
                case "V":
                    Console.WriteLine(stringTemplate + 5);
                    break;
                default:
                    Console.WriteLine("The characters' you entered is not a Roman numeral.");
                    break;
            }
        }
    }
}