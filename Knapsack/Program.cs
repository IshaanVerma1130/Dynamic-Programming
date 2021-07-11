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
            int w = 2;

            var knapsack = new Knapsack(n, w);
            var subsetSum = new SubsetSum(n, w);
            var equalSumSubset = new EqualSumPartition();
            var countSubsetSum = new CountSubsetSum(n, w);
            var minSubsetDiff = new MinSubsetDiff();
            var countSubsetDiff = new CountSubsetDiff();
            var targetCombos = new TargetSum();

            // Knapsack 01 Recursive Memoization
            Console.WriteLine(knapsack.Knapsack01RecursiveMemoized(wt, val, w, n));

            // Knapsack 01 Tabulation
            Console.WriteLine(knapsack.Knapsack01Tabulation(wt, val, w, n));

            // Subset is found with sum equal to a given number
            Console.WriteLine(subsetSum.IsFound(wt, w, n));

            // Subsets are found with their sum being equal
            Console.WriteLine(equalSumSubset.IsFound(wt, n));

            // Count of Subsets with sum equal to given number
            Console.WriteLine(countSubsetSum.CountSubsets(wt, w, n));

            // Min difference of subsets
            Console.WriteLine(minSubsetDiff.MinDiff(wt, n));

            // Count of subsets with their diff equal to a given number
            Console.WriteLine(countSubsetDiff.CountSubsets(wt, w, n));

            // number of cmobinations to get desired sum by changing signs in an array
            Console.WriteLine(targetCombos.Combos(wt, w, n));
        }
    }
}
