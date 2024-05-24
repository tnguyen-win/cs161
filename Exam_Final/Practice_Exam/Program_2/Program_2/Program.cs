/*
    Write and test a generic method that can be used to get a double value from the user.
    It should verify that the value entered by the user is a double and is within the acceptable range and force the user to continue entering data until the input is correct. 

    The method should be called GetDouble.
    It should take a string that represents the prompt to the user as well as a double that represents the lowest acceptable double value and a double that represents the highest acceptable double value as it's 3 parameters.
    It should return the double value entered by the user.

    Upload a file that contains your method definition as well as your test code in Main. 
*/
using System;
namespace Program_2 {
    class Program {
        static void Game(bool init) {
            if (init == false) Console.WriteLine("");
            Console.Write("Enter a double value within the range 1-10: ");
            string promptDoubleValue = Console.ReadLine();
            Console.WriteLine("");
            if (GetDouble(promptDoubleValue, 0, 10) == -1) {
                Console.WriteLine("The value you entered was either not a double or not within the range 1-10. Try again.");
                Game(false);
            }
            else Console.WriteLine($"You entered {GetDouble(promptDoubleValue, 0, 10)}.");
        }
        static double GetDouble(string promptDoubleValue, int min, int max) {
            if (double.TryParse(promptDoubleValue, out double result)) if (result >= min && result <= max) return result;
            return -1;
        }
        static void Main() {
            Game(true);
        }
    }
}