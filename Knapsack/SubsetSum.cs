﻿namespace DynamicProgramming
{
    class SubsetSum
    {
        public bool[,] dp;

        public SubsetSum(int n, int w)
        {
            dp = new bool[n + 1, w + 1];

            for (int i = 0; i < n + 1; i++)
                dp[i, 0] = true;

            for (int j = 1; j < w + 1; j++)
                dp[0, j] = false;
        }

        public bool IsFound(int[] wt, int w, int n)
        {
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < w + 1; j++)
                {
                    if (wt[i - 1] <= j)
                    {
                        dp[i, j] = dp[i - 1, j - wt[i - 1]] || dp[i - 1, j];
                    }

                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                }
            }

            return dp[n, w];
        }
    }
}
