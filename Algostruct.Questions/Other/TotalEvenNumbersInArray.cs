using System;
using System.Linq;

namespace Algostruct.Questions.Other
{
    public class TotalEvenNumbersInArray
    {
        public string Name => "Find Total Even Numbers In The Array.";
        public string Description => "Given an array of ints, write a C# method to total all the values that are even numbers.";

        public void Present()
        {
            int[] ints = new[] { 1, 2, 3, 4, 5, 6, 12, 18, 21, 26, 35, 38, 46, 53 };

            int total = ints.Where(i => i % 2 == 0).Sum();

            Console.WriteLine(total);
        }
    }
}
