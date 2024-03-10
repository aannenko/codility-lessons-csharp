// https://app.codility.com/demo/results/trainingUHJUDS-Q6R/

Console.WriteLine(FindEquilibrium([3, 1, 2, 4, 3])); // 1

// Find min difference between the parts' sums if A is split in two parts
static int FindEquilibrium(int[] A)
{
    int left = A[0];
    int right = A.Sum() - left;
    int diff = int.MaxValue;

    for (int i = 1; i < A.Length; i++)
    {
        var temp = Math.Abs(left - right);
        if (temp < diff)
            diff = temp;

        left += A[i];
        right -= A[i];
    }

    return diff;
}
