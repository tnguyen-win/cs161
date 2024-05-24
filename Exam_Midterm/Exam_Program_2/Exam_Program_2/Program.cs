using System;
/*
 Assume that you've been asked to produce an application that calculates the sale price of an item.
 The original price of the item and a sale code (one of the 4 numbers 1, 2, 3 or 4) will be provided by the user.
 The sale codes produce the following percent discount: 1 means 50% off, 2 means 40% off, 3 means 33% off and 4 means 25% off.
 The application should display the amount of the discount as well as the sale price. 
 For example, when the user enters 2 for the sale code and $10 for the original price, the discount is 40%.  The amount of the discount is 10 * .40 or $4.  The sale price is 10 - 4 or $6.
 An IPO chart and an algorithm in pseudocode is given below. 
 In replit.com or Visual Studio, translate the algorithm into syntactically correct C# code.  Upload a text file containing your Main method in moodle.
 
 Input
     originalPrice
     saleCode

 Processing
     get originalPrice
     get saleCode
     determine discountPercent
     calculate discountAmount
     calculate salePrice
     display discountAmount
     display salePrice

 Output
     discountAmount
     salePrice

 Algorithm

 display instructions
 get originalPrice 
 get saleCode 

 if saleCode = 1 (you could use a switch statement here instead of a multi-branching if)
  discountPercent = .5
 else if saleCode = 2
   discountPercent = .4
 else if saleCode = 3
  discountPercent = .33
 else if saleCode = 4
   discountPercent = .25
 end if
 discountAmount = originalPrice * discountPercent
 salePrice = originalPrice - discountAmount
 display discountAmount
 display salePrice
 */
namespace Exam_Program_2 {
    class Program {
        static void Main() {
            Console.WriteLine("Enter the original price:");
            int promptOrignalPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Enter the sales code (Number between 1-4):");
            int promptSalesCode = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            double discountPercent = 0.0;
            switch (promptSalesCode) {
                case 1:
                    discountPercent = 0.5;
                    break;
                case 2:
                    discountPercent = 0.4;
                    break;
                case 3:
                    discountPercent = 0.33;
                    break;
                case 4:
                    discountPercent = 0.25;
                    break;
                
            }
            double discountAmount = promptOrignalPrice * discountPercent;
            double salesPrice = promptOrignalPrice - discountAmount;
            Console.WriteLine($"Your discount is ${discountAmount}.");
            Console.WriteLine($"And your sales price is ${salesPrice}.");
        }
    }
}