// https://app.codility.com/demo/results/trainingGN9P48-BHB/ bitmap

Console.WriteLine(IsPermutation([4, 1, 3, 2])); // 1
Console.WriteLine(IsPermutation([4, 1, 3])); // 0
Console.WriteLine(IsPermutation([4, 2, 3])); // 0

// to be a permutation, array A must contain all numbers in range 1 to N
// [4, 1, 3, 2] is a permutation, [4, 1, 3] is not because 2 is missing
// return 1 if array A is a permutation, otherwise 0
static int IsPermutation(int[] A)
{
    var bits = new bool[A.Length];
    var bitsFound = 0;
    for (int i = 0; i < A.Length; i++)
    {
        var valueMinusOne = A[i] - 1;
        if (valueMinusOne >= A.Length || bits[valueMinusOne])
        {
            return 0;
        }
        else
        {
            bits[valueMinusOne] = true;
            bitsFound++;
        }
    }

    return bitsFound == bits.Length ? 1 : 0;
}