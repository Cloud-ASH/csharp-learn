using System;

namespace ArrayAndStringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Copy an array");
            Console.WriteLine("2. Manage a list (Add, Remove, Clear)");
            Console.WriteLine("3. Find primes in a range");
            Console.WriteLine("4. Rotate and sum arrays");
            Console.WriteLine("5. Find the longest sequence of equal elements");
            Console.WriteLine("6. Find the most frequent number");
            Console.WriteLine("7. Reverse a string");
            Console.WriteLine("8. Reverse words in a sentence");
            Console.WriteLine("9. Find palindromic words");
            Console.WriteLine("10. Parse a URL");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ArrayAndStringExercises.CopyArray();
                    break;
                case 2:
                    ArrayAndStringExercises.ManageList();
                    break;
                case 3:
                    ArrayAndStringExercises.FindPrimesInRange();
                    break;
                case 4:
                    ArrayAndStringExercises.RotateAndSumArrays();
                    break;
                case 5:
                    ArrayAndStringExercises.FindLongestSequence();
                    break;
                case 6:
                    ArrayAndStringExercises.FindMostFrequentNumber();
                    break;
                case 7:
                    ArrayAndStringExercises.ReverseString();
                    break;
                case 8:
                    ArrayAndStringExercises.ReverseWordsInSentence();
                    break;
                case 9:
                    ArrayAndStringExercises.FindPalindromes();
                    break;
                case 10:
                    ArrayAndStringExercises.ParseURL();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
