namespace DynamicProgramming
{
    class LCSString
    {
        public string CalcString(string a, string b, int m, int n)
        {
            var obj = new LCS(m, n);
            obj.LCSTabulation(a, b, m, n);
            var dp = obj.dp;

            int i = m;
            int j = n;

            string lcs = "";

            while (i > 0 && j > 0)
            {
                if (a[i - 1] == b[j - 1])
                {
                    lcs = a[i - 1] + lcs;
                    i--;
                    j--;
                }

                else
                {
                    if (dp[i - 1, j] > dp[i, j - 1])
                        i--;

                    else j--;
                }
            }

            return lcs;
        }
    }
}
