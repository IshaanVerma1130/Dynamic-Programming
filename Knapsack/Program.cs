using System;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] val = { 60, 100, 120 };
            int[] wt = { 10, 20, 30 };
            int w = 50;
            int n = 3;

            var knapsack = new Knapsack(3, 50);
            Console.WriteLine(knapsack.Knapsack01Recursive(wt, val, w, n));
            Console.WriteLine(knapsack.Knapsack01Memoized(wt, val, w, n));
        }
    }
}
