// https://app.codility.com/demo/results/trainingV3SW7B-EP2/

Console.WriteLine(GetMaxSliceSum([3, 2, -6, 4, 0])); // 5

static int GetMaxSliceSum(int[] A)
{
    var streak = A[0];
    var best = streak;
    for (int i = 1; i < A.Length; i++)
    {
        streak = Math.Max(A[i], streak + A[i]);
        best = Math.Max(best, streak);
    }

    return best;
}
