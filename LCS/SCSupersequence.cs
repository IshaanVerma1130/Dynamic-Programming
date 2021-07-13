namespace DynamicProgramming
{
    class SCSupersequence
    {
        public int CalcSCSupersequence(string a, string b, int m, int n)
        {
            var lcs = new LCS(m, n);
            var lcsLength = lcs.LCSTabulation(a, b, m, n);
            var length = a.Length + b.Length;

            return length - lcsLength;
        }
    }
}
