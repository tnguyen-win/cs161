using System;
class Program {
    static void Main(string[] args) {
        /* Generate Two Random Numbers */
        Random rnd = new Random();
        int r1 = rnd.Next(10, 999);
        int r2 = rnd.Next(10, 999);
        int total = r1 + r2;
        /* Display The Random Numbers */
        Console.WriteLine($"What is ({r1} + {r2})?");
        /* Get Possible Solution From User */
        int promptSolution = int.Parse(Console.ReadLine());
        /* Display Real Total */
        Console.WriteLine("");
        Console.WriteLine($"The correct answer is:\n{total}");
    }
}