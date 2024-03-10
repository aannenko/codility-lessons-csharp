// https://app.codility.com/demo/results/trainingGS9XC7-3QS/

Console.WriteLine(FindMissingInteger([1, 3, 6, 4, 1, 2])); // 5
Console.WriteLine(FindMissingInteger([1, 2, 3])); // 4
Console.WriteLine(FindMissingInteger([-1, -3])); // 1

// get smallest positive integer absent from A
static int FindMissingInteger(int[] A)
{
    var flags = new bool[A.Length];
    for (int i = 0; i < A.Length; i++)
        if (A[i] > 0 && A[i] <= flags.Length)
            flags[A[i] - 1] = true;

    var index = Array.IndexOf(flags, false);
    return index == -1 ? flags.Length + 1 : index + 1;
}