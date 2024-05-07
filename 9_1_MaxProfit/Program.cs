// https://app.codility.com/demo/results/trainingZ7M2N3-YX9/

Console.WriteLine(GetMaxProfit([23171, 21011, 21123, 21366, 21013, 21367])); // 356

// Array A contains daily prices of a stock share.
// Find best profit if a share was bought on one day and sold on the other.
static int GetMaxProfit(int[] A)
{
    var streak = 0;
    var best = 0;
    for (int i = 1; i < A.Length; i++)
    {
        streak = Math.Max(0, streak + A[i] - A[i - 1]);
        best = Math.Max(best, streak);
    }

    return best;
}
