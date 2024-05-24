using System;
class Program {
    public static void Main(string[] args) {
        /* Get Temperature */
        Console.WriteLine("Enter a temperature in degrees Fahrenheit:");
        int promptFahrenheit = int.Parse(Console.ReadLine());
        /* Calculate Celsius */
        Console.WriteLine("");
        int c = (int)(5.0 / 9 * (promptFahrenheit - 32));
        Console.WriteLine(c);
    }
}