using System;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] val = { 1, 3, 4, 5, 7 };
            int[] wt = { 1, 5, 3, 7, 4 };
            int w = 20;
            int n = wt.Length;

            var knapsack = new Knapsack(n, w);
            Console.WriteLine(knapsack.Knapsack01Recursive(wt, val, w, n));
            Console.WriteLine(knapsack.Knapsack01Memoized(wt, val, w, n));

            var s = new SubsetSum(n, w);
            Console.WriteLine(s.IsFound(wt, w, n));
        }
    }
}
