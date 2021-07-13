using System;

namespace DynamicProgramming
{
    class CoinChange
    {
        int[,] dp;

        public CoinChange(int n, int w)
        {
            dp = new int[n + 1, w + 1];
        }

        public int MaxNoOfWays(int[] wt, int w, int n)
        {
            for (int i = 0; i < n + 1; i++)
                dp[i, 0] = 1;

            for (int j = 1; j < w + 1; j++)
                dp[0, j] = 0;

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < w + 1; j++)
                {
                    if (wt[i - 1] <= j)
                        dp[i, j] = dp[i - 1, j] + dp[i, j - wt[i - 1]];

                    else
                        dp[i, j] = dp[i - 1, j];
                }
            }

            return dp[n, w];
        }

        public int MinNoOfCoins(int[] wt, int w, int n)
        {
            for (int i = 1; i < n + 1; i++)
                dp[i, 0] = 0;

            for (int j = 0; j < w + 1; j++)
                dp[0, j] = int.MaxValue - 1;

            for (int j = 1; j < w + 1; j++)
            {
                if (j % wt[0] == 0) dp[1, j] = j / wt[0];
                else dp[1, j] = int.MaxValue - 1;
            }

            for (int i = 2; i < n + 1; i++)
            {
                for (int j = 1; j < w + 1; j++)
                {
                    if (wt[i - 1] <= j)
                        dp[i, j] = Math.Min(dp[i, j - wt[i - 1]] + 1, dp[i - 1, j]);

                    else
                        dp[i, j] = dp[i - 1, j];
                }
            }

            return dp[n, w];
        }
    }
}
