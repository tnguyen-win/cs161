using System;
class Program_5 {
	/*---------------
	|   IPO CHART   |
	-----------------
	|   INPUT   |
	-------------------------------
	|   Get given pennies count   |
	|   Get given nickels count	  |
	|   Get given dimes count	  |
	|   Get given quarters count  |
	-------------------------------
	|   PROCESSING  |
	---------------------------------------------------------------------
	|   Check if given total amount is in just change or also in cash	|
	|   Check if given total amount matches a dollar exactly			|
	|   Check if given total amount is more than exactly a dollar		|
	|   Check if given total amount is less than exactly a dollar		|
	---------------------------------------------------------------------
	|   OUTPUT  |
	---------------------------------------------------------------------------------------------
	|   Display message depending on if given total amount is in just change or also in cash	|
	|   Display message depending on if given total amount matches a dollar exactly				|
	|   Display message depending on if given total amount is more than exactly a dollar		|
	|   Display message depending on if given total amount is less than exactly a dollar		|
	-------------------------------------------------------------------------------------------*/
	static void Main(string[] args) {
		/* Initialize Coin Values */
		float valuesPennies = 0.01f;
		float valuesNickels = 0.05f;
		float valuesDimes = 0.1f;
		float valuesQuarters = 0.25f;
		/* Display - Instructions - Initial */
		Console.WriteLine("Enter an amount of money to make a single dollar. (Pennies, Nickels, Dimes, & Quarters.)");
		Console.WriteLine("");
		/* Display - Instructions - Pennies */
		Console.WriteLine("How many pennies do you want to use?");
		int promptPennies = int.Parse(Console.ReadLine());
		Console.WriteLine("");
		/* Display - Instructions - Nickels */
		Console.WriteLine("How many nickels do you want to use?");
		int promptNickels = int.Parse(Console.ReadLine());
		Console.WriteLine("");
		/* Display - Instructions - Dimes */
		Console.WriteLine("How many dimes do you want to use?");
		int promptDimes = int.Parse(Console.ReadLine());
		Console.WriteLine("");
		/* Display - Instructions - Quarters */
		Console.WriteLine("How many quarters do you want to use?");
		int promptQuarters = int.Parse(Console.ReadLine());
		Console.WriteLine("");
		/* Calculate Total */
		float totalSum = (promptPennies * valuesPennies) + (promptNickels * valuesNickels) + (promptDimes * valuesDimes) + (promptQuarters * valuesQuarters);
		/* Display Coin Values */
		Console.Write("Your entered total is: ");
		if (totalSum >= 1) Console.WriteLine($"${totalSum}.");
		else if (totalSum < 1) Console.WriteLine($"{totalSum}¢.");
		Console.WriteLine("");
		/* Display Final */
		if (totalSum == 1.0) Console.WriteLine("Congratulations! You gave exactly one dollar.");
		else if (totalSum > 1.0) Console.WriteLine("Sorry. You gave more than one dollar. Try giving an exact value of one dollar next time.");
		else if (totalSum < 1.0) Console.WriteLine("Sorry. You gave less than one dollar. Try giving an exact value of one dollar next time.");
    }
}