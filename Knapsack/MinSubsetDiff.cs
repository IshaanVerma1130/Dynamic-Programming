using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DynamicProgramming
{
    class MinSubsetDiff
    {
        public int MinDiff(int[] wt, int n)
        {
            int min_sum = int.MaxValue;
            int sum = wt.Sum();

            var s = new SubsetSum(n, sum);
            s.IsFound(wt, sum, n);

            int row = s.dp.GetLength(0);
            int column = s.dp.GetLength(1);

            for (int i = 0; i <= column / 2; i++)
            {
                if (s.dp[row - 1, i])
                    min_sum = Math.Min(min_sum, (column - 1) - 2 * i);
            }

            return min_sum;
        }
    }
}
