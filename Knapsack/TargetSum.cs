namespace DynamicProgramming
{
    class TargetSum
    {
        public int Combos(int[] wt, int w, int n)
        {
            var c = new CountSubsetDiff();
            return c.CountSubsets(wt, w, n);
        }
    }
}
