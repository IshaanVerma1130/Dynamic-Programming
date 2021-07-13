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
            int w = 10;

            var knapsack = new Knapsack01(n, w);
            var subsetSum = new SubsetSum(n, w);
            var equalSumSubset = new EqualSumPartition();
            var countSubsetSum = new CountSubsetSum(n, w);
            var minSubsetDiff = new MinSubsetDiff();
            var countSubsetDiff = new CountSubsetDiff();
            var targetCombo = new TargetSum();
            var coinCombo = new CoinChange(n, w);

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

            // Number of combinations to get desired sum by changing signs in an array
            Console.WriteLine(targetCombo.Combos(wt, w, n));

            // Number of ways to choose coins equal to a given sum
            Console.WriteLine(coinCombo.MaxNoOfWays(wt, w, n));

            // Min number of coins that add up tp a given sum
            Console.WriteLine(coinCombo.MinNoOfCoins(wt, w, n));
        }
    }
}
