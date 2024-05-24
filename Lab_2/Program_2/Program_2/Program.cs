using System;
class Program {
    static void Main(string[] args) {
		/* Display Instructions  */
		Console.WriteLine("Enter a price that's less than 1 dollar or 100 cents:");
		Console.WriteLine();
		/* Calculate Change */
		int promptPrice = int.Parse(Console.ReadLine());
		// Write a statement that declares a variable change and assigns it to the difference between 100 and price
		int change = 100 - promptPrice;
		// Write a statement that declares a variable quarters and assigns it to the change / 25
		int quarters = change / 25;
		// Write a statement that assigns a new value to change based on the number of quarters * 25
		change = change - quarters * 25;
		// Write a statement that declares a variable dimes and assigns it to the change / 10
		int dimes = quarters / 10;
		// Write a statement that assigns a new value to change based on the number of dimes * 10
		change = change - dimes * 10;
		// Write a statement that declares a variable nickels and assigns it to the change / 5
		int nickles = change / 5;
		// Write a statement that assigns a new value to change based on the number of nickels * 5
		change = change - nickles * 5;
		// Write a statement that declares a variable pennies and assigns it to the value in change
		int pennies = change;
		/* Display Change */
		// Write a statement that displays an appropriate message to the user as well as the value in the variables 
		// price, change, quarters, dimes, nickels and pennies
		Console.WriteLine($"The given price was {promptPrice}, and your change was {quarters} quarters, {dimes} dimes, {nickles} nickelsBB, and {pennies} pennies.");
	}
}