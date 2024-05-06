// https://app.codility.com/demo/results/trainingFP2U2P-ATG/

Console.WriteLine(FindMajorityElement([3, 4, 3, 2, 3, -1, 3, 3]));

// Find any index of the element in array A
// which occurs more than half of the time.
// If there is no such element, return -1.
static int FindMajorityElement(int[] A)
{
    int dominatorIndex = 0, count = 0;
    for (int i = 0; i < A.Length; i++)
    {
        if (count == 0)
            dominatorIndex = i;

        if (A[i] == A[dominatorIndex])
            count++;
        else
            count--;
    }

    count = 0;
    var half = A.Length / 2;
    for (int i = 0; i < A.Length; i++)
        if (A[i] == A[dominatorIndex] && ++count > half)
            return dominatorIndex;

    return -1;
}
