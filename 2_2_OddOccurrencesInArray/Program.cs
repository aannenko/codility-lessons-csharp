// https://app.codility.com/demo/results/trainingXGJYWF-DBH/

Console.WriteLine(FindIntWithoutPair([9, 3, 9, 3, 9, 7, 9]));

static int FindIntWithoutPair(int[] A)
{
    var result = 0;
    for (int i = 0; i < A.Length; i++)
        result ^= A[i];

    return result;
}
