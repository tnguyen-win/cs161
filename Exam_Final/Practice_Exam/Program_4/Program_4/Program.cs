/*
    Write and test a method that uses bubble sort to sort an array of integers.
    The method should take an array of integers and the number of elements in the array as parameters.
    It does not directly return a value BUT the array is a reference type.
    Changes made to the array inside the method are reflected in the calling code.
    An algorithm for bubble sort (as well as a link to a description of bubble sort) is provided below.
    Test your method with a randomly generated array of integers.

    Bubble Sort Description and Algorithm:  https://tutorialspoint.com/data_structures_algorithms/bubble_sort_algorithm.htm

    Upload a file that contains your method definition as well as your test code in Main.
*/
using System;
namespace Program_4 {
    class Program {
        public static int[] myList = new int[5];
        static void Main() {
            for (int i = 0; i < myList.Length; i++) myList[i] = new Random().Next(0, 100);
            Console.WriteLine($"myList: {string.Join(",", BubbleSort(myList))}");
        }
        static int[] BubbleSort(int[] myList) {
            int loop = myList.Length;
            for (int i = 0; i < loop - 1; i++) {
                bool swapped = false;
                for (int j = 0; j < loop - 1; j++) {
                    if (myList[j] > myList[j + 1]) {
                        myList[j] = myList[j + 1];
                        swapped = true;
                    }
                }
                if (swapped == false) break;
            }
            return myList;
        }
    }
}