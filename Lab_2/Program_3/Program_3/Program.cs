using System;
class Program {
    static void Main(string[] args) {
        /* Get USD Amount */
        Console.WriteLine("Enter an amount of United States Dollars:");
        double promptAmount = double.Parse(Console.ReadLine());
        /* Calculate Conversion Rate */
        double EUR = promptAmount * .924143;
        double CAD = promptAmount * 1.346443;
        double MXN = promptAmount * 18.96682;
        /* Display Conversion Rate */
        Console.WriteLine("");
        Console.WriteLine("The exchange rate is:");
        Console.WriteLine($"{EUR} (European Euros), {CAD} (Canadian Dollars), and {MXN} (Mexican Pesos).");
    }
}