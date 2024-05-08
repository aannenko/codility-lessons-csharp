// https://app.codility.com/demo/results/trainingT43H4Y-VNR/

Console.WriteLine(GetMaxDoubleSliceSum([3, 2, 6, -1, 4, 5, -1, 2])); // 17

// In array A, find largest sum of items in a double slice,
// which can be represented as a triplet of indices (X, Y, Z)
// where 0 <= X < Y < Z < N and the sum is calculated for [X+1..Y-1, Y+1..Z-1].
// Note! Here we use an adapted bidirectional Kadane's algorithm.
static int GetMaxDoubleSliceSum(int[] A)
{
    int[] left = new int[A.Length];
    int[] right = new int[A.Length];

    for (int i = 1; i < A.Length - 1; i++)
        left[i] = Math.Max(left[i - 1] + A[i], 0);

    for (int i = A.Length - 2; i > 0; i--)
        right[i] = Math.Max(right[i + 1] + A[i], 0);

    int max = 0;
    for (int i = 1; i < A.Length - 1; i++)
        max = Math.Max(max, left[i - 1] + right[i + 1]);

    return max;
}
