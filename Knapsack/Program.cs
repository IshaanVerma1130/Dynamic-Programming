using System;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] val = { 1, 3, 4, 5, 7 };
            int[] wt = { 1, 5, 3, 7, 4 };
            int n = wt.Length;
            int w = 20;

            var knapsack = new Knapsack(n, w);
            var subsetSum = new SubsetSum(n, w);
            var equalSumSubset = new EqualSumPartition();

            // Knapsack 01 Recursive Memoization
            Console.WriteLine(knapsack.Knapsack01RecursiveMemoized(wt, val, w, n));

            // Knapsack 01 Tabulation
            Console.WriteLine(knapsack.Knapsack01Tabulation(wt, val, w, n));

            // Subset Sum
            Console.WriteLine(subsetSum.IsFound(wt, w, n));

            // Equal Sum Partition
            Console.WriteLine(equalSumSubset.IsFound(wt, n));
        }
    }
}
