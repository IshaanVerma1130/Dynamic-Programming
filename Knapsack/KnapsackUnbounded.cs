using System;
namespace DynamicProgramming
{
    class KnapsackUnbounded
    {
        private int[,] dp;

        /*
         * Initialize dp array with dimensions n+1 * w+1 where n = sizeof(value), w = capacity of knapsack
         * Make all the elements of this array equal to -1
         */

        public KnapsackUnbounded(int n, int w)
        {
            dp = new int[n + 1, w + 1];

            for (int i = 0; i < n + 1; i++)
                dp[i, 0] = 0;

            for (int j = 0; j < w + 1; j++)
                dp[0, j] = 0;
        }

        public int KnapsackUnboundedTabulation(int[] wt, int[] val, int w, int n)
        {
            /* We go from the top of the dp array to the bottom using a dual for loop
             * i = n
             * j = w
             */
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < w + 1; j++)
                {
                    /* We check if the weight of the previous item is less than the current weight remaining in the knapsack
                     * We take the maximum out of when:
                     *      1. We include the value of the previous item but leave the option to choose it again
                     *      2. We dont include the value of the previous item
                     */
                    if (wt[i - 1] <= j)
                        dp[i, j] = Math.Max(val[i - 1] + dp[i, j - wt[i - 1]], dp[i - 1, j]);

                    else
                        dp[i, j] = dp[i - 1, j];
                }
            }

            // We return the bottom last element of the dp array
            return dp[n, w];
        }
    }
}
