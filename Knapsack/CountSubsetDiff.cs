using System.Linq;

namespace DynamicProgramming
{
    class CountSubsetDiff
    {
        public int CountSubsets(int[] wt, int w, int n)
        {
            int sum = (w + wt.Sum()) / 2;
            var s = new CountSubsetSum(n, sum);

            return s.CountSubsets(wt, sum, n);
        }
    }
}
