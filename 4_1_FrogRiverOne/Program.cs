// https://app.codility.com/demo/results/trainingMKP397-466/ HashSet 29ns
// https://app.codility.com/demo/results/trainingP4MK4R-UHB/ bitmap 5ns

Console.WriteLine(GetNumberOfSecondsToCrossTheRiver(5, [1, 3, 1, 4, 2, 3, 5, 4])); // 6
Console.WriteLine(GetNumberOfSecondsToCrossTheRiver(2, [1, 3, 1, 4, 2, 3, 5, 4])); // 4

// A small frog wants to get to the other side of a river.
// initial frog's position = 0, jump length = 1
// target position = X + 1 (X is the last position on the river)
// array A = leaves falling every second onto the surface of the river
// array A's indices = seconds
// A[i] = position on the river where a leaf falls
// Find how many seconds it takes for all positions to have leaves on them.
// If the river cannot be crossed, return -1.

static int GetNumberOfSecondsToCrossTheRiver(int X, int[] A)
{
    var steps = X;
    var bitmap = new bool[X];
    for (int i = 0; i < A.Length; i++)
    {
        ref var bit = ref bitmap[A[i] - 1];
        if (A[i] <= X && !bit)
        {
            bit = true;
            if (--steps == 0)
                return i;
        }
    }

    return -1;
}
