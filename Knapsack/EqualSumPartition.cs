using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    class EqualSumPartition
    {
        public bool IsFound(int[] wt, int n)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
                sum += wt[i];

            if (sum % 2 != 0) return false;

            var subset = new SubsetSum(n, sum / 2);

            return subset.IsFound(wt, sum / 2, n);
        }
    }
}
