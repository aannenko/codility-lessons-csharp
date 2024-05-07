// https://app.codility.com/demo/results/training54YBXJ-NWX/

Console.WriteLine(GetMaxProfit([23171, 21011, 21123, 21366, 21013, 21367])); // 356

// Array A contains daily prices of a stock share.
// Find best profit if a share was bought on one day and sold on the other.
static int GetMaxProfit(int[] A)
{
    var streak = 0;
    var best = 0;
    for (int i = 1; i < A.Length; i++)
    {
        streak += A[i] - A[i - 1];
        if (streak < 0)
            streak = 0;

        if (best < streak)
            best = streak;
    }

    return best > 0 ? best : 0;
}