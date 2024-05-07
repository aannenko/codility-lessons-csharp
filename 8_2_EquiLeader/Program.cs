// https://app.codility.com/demo/results/training456KY2-CRF/

Console.WriteLine(CountEquiLeaders([4, 3, 4, 4, 4, 2])); // 2

// A leader is the value that occurs in more than half of the elements of A.
// Given array A of length N, equi leader is the index S which splits A
// so that the ranges A[0..S+1] and A[S+2..N] (C# syntax) had the same leader.
// The task is to count such equi leader indices.
static int CountEquiLeaders(int[] A)
{
    if (!TryGetLeaderWithCount(A, out var leader, out var count))
        return 0;

    var leftLeaderCount = 0;
    var rightLeaderCount = count;
    var equiLeaderCount = 0;
    for (int i = 0; i < A.Length; i++)
    {
        if (A[i] == leader)
        {
            leftLeaderCount++;
            rightLeaderCount--;
        }

        if (leftLeaderCount > (i + 1) / 2 && rightLeaderCount > (A.Length - 1 - i) / 2)
            equiLeaderCount++;
    }

    return equiLeaderCount;
}

static bool TryGetLeaderWithCount(int[] A, out int leader, out int count)
{
    leader = 0;
    count = 0;
    for (int i = 0; i < A.Length; i++)
    {
        if (count == 0)
        {
            leader = A[i];
            count = 1;
            continue;
        }

        if (A[i] == leader)
            count++;
        else
            count--;
    }

    count = 0;
    for (int i = 0; i < A.Length; i++)
        if (A[i] == leader)
            count++;

    return count > A.Length / 2;
}