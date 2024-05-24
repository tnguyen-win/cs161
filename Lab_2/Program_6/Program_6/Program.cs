using System;
using System.Text;
class Program {
    static void Main(string[] args) {
        /*
            2 1 / 4 cups all-purpose flour
            1 teaspoon baking soda
            1 teaspoon salt
            1 cup(2 sticks) butter, softened
            3 / 4 cup granulated sugar
            3 / 4 cup packed brown sugar
            1 teaspoon vanilla extract
            2 large eggs
            2 cups(12 - oz.pkg.) NESTLÉ® TOLL HOUSE® Semi - Sweet Chocolate Morsels
            1 cup chopped nuts
        */
        /* Get Cookies Length */
        int cookiesLength = 60;
        Console.WriteLine("How many cookies do you want to make?");
        float promptCookiesLength = float.Parse(Console.ReadLine());
        float currentCookiesLength = promptCookiesLength / cookiesLength;
        Console.Write("");
        /* Variables */
        float flour = 2.25f * currentCookiesLength;
        float bakingSoda = 1f * currentCookiesLength;
        float salt = 1f * currentCookiesLength;
        float butter = 1f * currentCookiesLength;
        float butterSticks = (butter * 2f);
        float sugarGranulated = 0.75f * currentCookiesLength;
        float sugarBrown = 0.75f * currentCookiesLength;
        float vanilla = 1f * currentCookiesLength;
        float eggs = 2f * currentCookiesLength;
        float chocolate = 2f * currentCookiesLength;
        float nuts = 1f * currentCookiesLength;
        /* Display Total Ingredients */
        // Flour
        Console.WriteLine("");
        Console.WriteLine($"To create {promptCookiesLength} cookies, you'll need:");
        Console.WriteLine($"{flour.ToString("0.###")} cups' of all-purpose flour.");
        // Baking Soda
        Console.WriteLine($"{bakingSoda.ToString("0.###")} teaspoons' of baking soda.");
        // Salt
        Console.WriteLine($"{salt.ToString("0.###")} teaspoons' of salt.");
        // Butter
        Console.WriteLine($"{salt.ToString("0.###")} cups' ({butterSticks.ToString("0.###")} sticks) of butter, softened.");
        // Sugar - Granulated
        Console.WriteLine($"{sugarGranulated.ToString("0.###")} cups' of granulated sugar.");
        // Sugar - Brown
        Console.WriteLine($"{sugarBrown.ToString("0.###")} cups' of brown sugar.");
        // Vanilla Extract
        Console.WriteLine($"{vanilla.ToString("0.###")} teaspoons' of vanilla extract.");
        // Eggs
        Console.WriteLine($"{eggs.ToString("0.###")} large eggs'.");
        // Unicode Symbols Hack (for Copyright symbol)
        Console.OutputEncoding = Encoding.UTF8;
        // Chocolate
        Console.WriteLine($"{chocolate.ToString("0.###")} cups' of NESTLÉ® TOLL HOUSE®\nSemi - Sweet Chocolate Morsels.");
        // Nuts
        Console.WriteLine($"{nuts.ToString("0.###")} chopped nuts'.");
    }
}