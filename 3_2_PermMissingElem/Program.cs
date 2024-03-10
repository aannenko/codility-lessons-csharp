// https://app.codility.com/demo/results/trainingHTVDF2-QVH/

int[] arr = [2, 1, 4, 5, 3, 7];
Console.WriteLine(FindIntMissingFromSequence(arr));

static int FindIntMissingFromSequence(int[] A)
{
    var n = (long)A.Length + 1; // how many elements should be
    return (int)((n * (n + 1) / 2) - A.Sum(i => (long)i));
}
