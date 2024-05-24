using System;
/*
 Algorithm
 display instructions
 get number
 create a random number generator
 declare 2 integer variables d1 and d2
 rolls = 0
 do
    d1 = random number between 1 and 6
    d2 = random number between 1 and 6
    increment rolls
    display rolls, d1 and d2
 while rolls < 3 and d1 + d2 is not equal to number
 if number = d1 + d2 then
    display YOU win
 else
    display COMPUTER wins
 end if
 */
namespace Exam_Program_3 {
    class Program {
        static void Main() {
            Console.WriteLine("Enter a possible total for two dices roles (Number between 2 - 12.):");
            int promptPotentialDiceNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            var r = new Random();
            int d1;
            int d2;
            int rolls = 0;
            do {
                d1 = r.Next(1, 6);
                d2 = r.Next(1, 6);
                rolls++;
                Console.WriteLine($"Your roll: {rolls}");
                Console.WriteLine($"Computer's first dice number: {d1}");
                Console.WriteLine($"Computer's second dice number: {d2}");
                Console.WriteLine("");
            } while (rolls < 3 && d1 + d2 != promptPotentialDiceNumber);
            if (d1 + d2 == promptPotentialDiceNumber) Console.WriteLine("Yay! You won.");
            if (rolls == 3) Console.WriteLine("Boo! You lost.");
        }
    }
}