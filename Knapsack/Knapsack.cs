using System;
namespace DynamicProgramming
{
    class Knapsack
    {
        private int[,] dp;

        /*
         * Initialize dp array with dimensions n+1 * w+1 where n = sizeof(value), w = capacity of knapsack
         * Make all the elements of this array equal to -1
        */

        public Knapsack(int n, int w)
        {
            dp = new int[n + 1, w + 1];

            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < w + 1; j++)
                {
                    dp[i, j] = -1;
                }
            }
        }

        public int Knapsack01Recursive(int[] wt, int[] val, int w, int n)
        {
            // Check when n = 0 or w = 0. In this case the answer must be 0 as we cannot get any highest value
            if (n == 0 || w == 0)
            {
                return 0;
            }

            // We check if the value we want is already calculated in the dp array
            if (dp[n, w] != -1)
            {
                return dp[n, w];
            }

            // If the weight of the current item if less than weight of knapsack we check if we should include it
            if (wt[n - 1] <= w)
            {
                /* We take the max of when:
                 *      1. We include the current value
                 *      2. We dont include the current value and procede further
                 * 
                 * Once we choose our option we store the value in the dp array
                */
                dp[n, w] = Math.Max(val[n - 1] + Knapsack01Recursive(wt, val, w - wt[n - 1], n - 1), Knapsack01Recursive(wt, val, w, n - 1));
            }

            // If the weight of current item is more than what is available int he knapsack we skip it
            else
            {
                // We store the value in the dp array
                dp[n, w] = Knapsack01Recursive(wt, val, w, n - 1);
            }

            // We return the calculate value as our answer
            return dp[n, w];
        }

        public int Knapsack01Memoized(int[] wt, int[] val, int w, int n)
        {
            for (int i = 0; i < n + 1; i++)
                for (int j = 0; j < w + 1; j++)
                {
                    if (i == 0 || j == 0)
                        dp[i, j] = 0;

                    else if (wt[i - 1] <= j)
                        dp[i, j] = Math.Max(val[i - 1] + dp[i - 1, j - wt[i - 1]], dp[i - 1, j]);

                    else
                        dp[i, j] = dp[i - 1, j];
                }

            return dp[n, w];
        }
    }
}
