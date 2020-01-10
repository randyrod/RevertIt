using System;

namespace RevertIt
{
    class Program
    {
        static void Main(string[] args)
        {
            var reverseMe = new [] { 5, 7, 8, 10, 11 };
            Console.WriteLine($"Array before reverse");
            PrintArray(reverseMe);

            ReverseArray(reverseMe);

            Console.WriteLine($"Array after reverse");
            PrintArray(reverseMe);
        }

        private static void ReverseArray(int[] arr)
        {
            // Implement arr.Reverse()
        }

        private static void PrintArray(int[] arr)
        {
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }
        }
    }
}