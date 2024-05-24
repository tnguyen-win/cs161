using System;
namespace Program_1 {
    class Program {
        // Variables
        public static int promptScore1;
        public static int promptScore2;
        public static int promptScore3;
        public static int currentStage = 0;
        public static int nextStage = 0;
        static void Main() {
            // Display instructions - Initial
            Console.WriteLine("Enter 3 quiz scores. (Each score should be of 0-50.)");
            // Newline
            Console.WriteLine("");
            // Check current stage
            while (currentStage == nextStage) {
                // Check stages
                if (currentStage == 0) scoreFirst(false);
                else if (currentStage == 1) scoreSecond(false);
                else if (currentStage == 2) scoreThird(false);
                else if (currentStage == 3) {
                    // Shorthand
                    int average = calculateAverage(new int[] { promptScore1, promptScore2, promptScore3 });
                    // Display - Final average score
                    Console.WriteLine($"Your final average score is: {average}");
                    // Display - Final average percentage
                    Console.WriteLine($"Your final percentage is: {(average * 100).ToString("0.00%")}");
                    // Display - Final score
                    if (average >= 90) Console.WriteLine("Your final grade is: [A]");
                    else if (average >= 80 && average <= 90) Console.WriteLine("B");
                    else if (average >= 70 && average <= 80) Console.WriteLine("C");
                    else if (average < 70) Console.WriteLine("F");
                }
                // Go to next stage if ready
                nextStage++;
            }
        }
        static void scoreFirst(bool is_recursive) {
            // Check - Should add newline
            if (is_recursive) Console.WriteLine("");
            // Display instructions - First score
            Console.WriteLine("First quiz score:");
            // Check if whole number
            try {
                // Shorthand
                int s = int.Parse(Console.ReadLine());
                // Get input - First score
                if (s >= 0 && s <= 50) {
                    promptScore1 = s;
                    currentStage++;
                } else scoreFirst(true);
            } catch {
                scoreFirst(true);
            }
            // Check - Should add newline
            if (!is_recursive) Console.WriteLine("");
        }
        static void scoreSecond(bool is_recursive) {
            // Check - Should add newline
            if (is_recursive) Console.WriteLine("");
            // Display instructions - Second score
            Console.WriteLine("Second quiz score:");
            // Check if whole number
            try {
                // Shorthand
                int s = int.Parse(Console.ReadLine());
                // Get input - Second score
                if (s >= 0 && s <= 50) {
                    promptScore2 = s;
                    currentStage++;
                }
                else scoreSecond(true);
            } catch {
                scoreSecond(true);
            }
            // Check - Should add newline
            if (!is_recursive) Console.WriteLine("");
        }
        static void scoreThird(bool is_recursive) {
            // Check - Should add newline
            if (is_recursive) Console.WriteLine("");
            // Display instructions - Third score
            Console.WriteLine("Third quiz score:");
            // Check if whole number
            try {
                // Shorthand
                int s = int.Parse(Console.ReadLine());
                // Get input - Third score
                if (s >= 0 && s <= 50) {
                    promptScore3 = s;
                    currentStage++;
                }
                else scoreThird(true);
            } catch {
                scoreThird(true);
            }
            // Check - Should add newline
            if (!is_recursive) Console.WriteLine("");
        }
        static int calculateAverage(int[] args) {
            int sum = 0;
            for (int i = 0; i < args.Length; i++) sum += args[i];
            return (sum / args.Length);
        }
    }
}