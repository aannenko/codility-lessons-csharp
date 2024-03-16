// https://app.codility.com/demo/results/trainingP3NQBS-VC5/

Console.WriteLine(CountDivisibleNumbersInRange(9, 12, 3)); // 2
Console.WriteLine(CountDivisibleNumbersInRange(6, 11, 2)); // 3

// Return the number of integers within the range [A..B] (B is inclusive) that are divisible by K
static int CountDivisibleNumbersInRange(int A, int B, int K)
{
    return B / K - A / K + (A % K == 0 ? 1 : 0);
}