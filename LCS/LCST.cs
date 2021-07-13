using System;

namespace DynamicProgramming
{
    class LCST
    {
        int[,] dp;

        public LCST(int m, int n)
        {
            dp = new int[m + 1, n + 1];

            for (int i = 0; i < m + 1; i++)
                dp[i, 0] = 0;

            for (int j = 0; j < n + 1; j++)
                dp[0, j] = 0;
        }

        public int LSCTTabulation(string a, string b, int m, int n)
        {
            for (int i = 1; i < m + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (a[i - 1] == b[j - 1])
                        dp[i, j] = 1 + dp[i - 1, j - 1];

                    else
                        dp[i, j] = 0;
                }
            }

            int max = 0;

            for (int i = 1; i < m + 1; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    max = Math.Max(max, dp[i, j]);
                }
            }

            return max;
        }
    }
}
