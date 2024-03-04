class Program
{
    static int MSC(string X, string Y, int m, int n)
    {
        int[,] L = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                    L[i, j] = 0;
                else if (X[i - 1] == Y[j - 1])
                    L[i, j] = L[i - 1, j - 1] + 1;
                else
                    L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
            }
        }

        return L[m, n];
    }

    static void Main(string[] args)
    {
        string X = "AGGTAB";
        string Y = "GXTXAYB";
        int m = X.Length;
        int n = Y.Length;
        Console.WriteLine($"Comprimento da MSC é: {MSC(X, Y, m, n)}");
    }
}
