using System;

namespace DynamicProgramming
{
    class LCS
    {
        public int[,] dp;

        public LCS(int m, int n)
        {
            dp = new int[m + 1, n + 1];

            for (int i = 0; i < m + 1; i++)
                for (int j = 0; j < n + 1; j++)
                    dp[i, j] = -1;
        }

        public int LCSRecursive(string a, string b, int m, int n)
        {
            if (n == 0 || m == 0)
                return 0;

            if (a[m - 1] == b[n - 1])
                return 1 + LCSRecursive(a, b, m - 1, n - 1);

            else
                return Math.Max(LCSRecursive(a, b, m - 1, n), LCSRecursive(a, b, m, n - 1));
        }

        public int LCSRecursiveMemoized(string a, string b, int m, int n)
        {
            if (n == 0 || m == 0)
                return 0;

            if (dp[m, n] != -1)
                return dp[n, m];

            if (a[m - 1] == b[n - 1])
                dp[m, n] = 1 + LCSRecursiveMemoized(a, b, m - 1, n - 1);

            else
                dp[m, n] = Math.Max(LCSRecursive(a, b, m - 1, n), LCSRecursive(a, b, m, n - 1));

            return dp[m, n];
        }

        public int LCSTabulation(string a, string b, int m, int n)
        {
            for (int i = 0; i < m + 1; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 0;
                        continue;
                    }

                    if (a[i - 1] == b[j - 1])
                        dp[i, j] = 1 + dp[i - 1, j - 1];

                    else
                        dp[i, j] = Math.Max(dp[i, j - 1], dp[i - 1, j]);
                }
            }

            return dp[m, n];
        }
    }
}
