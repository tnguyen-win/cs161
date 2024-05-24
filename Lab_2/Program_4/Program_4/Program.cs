using System;
class Program {
    static void Main(string[] args) {
        /* Get Majors Length */
        Console.WriteLine("Enter an amount of programming majors:");
        int promptMajorsLength = int.Parse(Console.ReadLine());
        /* Get Students Length */
        Console.WriteLine("");
        Console.WriteLine("Enter a total amount of students that are in a class:");
        int promptStudentsLength = int.Parse(Console.ReadLine());
        /* Calculate Percentage */
        Console.WriteLine("");
        decimal percentage = (promptMajorsLength * promptStudentsLength) * .01M;
        Console.WriteLine("Percentage of how many students of the ");
        Console.WriteLine("class are majoring in programming is:");
        Console.WriteLine($"{percentage}%");
    }
}