/*
    Write and test a method that can be used to determine the winner and increment either the user or the computer score for a round of Rock Paper Scissors.
    Please note that you are NOT being asked to write the entire Rock Paper Scissors game. 
    You can assume that you have the following GLOBAL constants:  ROCK, PAPER, SCISSORS, USERWINNER, COMPUTERWINNER.
    The method should be called DetermineWinner.
    It should take as parameters an integer that represents the user's move as well as an integer that represents the computer's move.
    Neither of these parameters will be changed by the method.
    It will take 2 additional parameters that may be edited by the method, an int that represents the user's score and another int that represents the computer's score.
    It will return an integer either USERWINNER or COMPUTERWINNER.  
    Upload a file that contains your method definition as well as your test code in Main.
*/
using System;
namespace Program_3 {
    class Program {
        public static int ROCK = 0;
        public static int PAPER = 1;
        public static int SCISSORS = 2;
        public static int USERWINNER;
        public static int COMPUTERWINNER;
        static void Main() {
            DetermineWinner(1, 2);
            Console.WriteLine($"Current score is | User ({USERWINNER}) | Computer ({COMPUTERWINNER})");
        }
        static int DetermineWinner(int chosenMoveUser, int chosenMoveComputer) {
            if (chosenMoveUser == ROCK && chosenMoveComputer == PAPER) return COMPUTERWINNER++;
            else if (chosenMoveUser == ROCK && chosenMoveComputer == SCISSORS) return USERWINNER++;
            else if (chosenMoveUser == PAPER && chosenMoveComputer == ROCK) return USERWINNER++;
            else if (chosenMoveUser == PAPER && chosenMoveComputer == SCISSORS) return COMPUTERWINNER++;
            else if (chosenMoveUser == SCISSORS && chosenMoveComputer == ROCK) return COMPUTERWINNER++;
            else if (chosenMoveUser == SCISSORS && chosenMoveComputer == PAPER) return USERWINNER++;
            return -1;
        }
    }
}