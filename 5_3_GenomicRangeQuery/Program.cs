// https://app.codility.com/demo/results/trainingYFF352-UT4/ first attempt
// https://app.codility.com/demo/results/trainingBNKAKF-2D3/ cleanup
// https://app.codility.com/demo/results/training9Z6653-6GZ/ chars instead of ints

using GenomicRangeQuery;

//var table = new SparseTableMin([2, 1, 3, 2, 2, 4, 1]);
//int[,] sparseTable =
//{
//    { 2, 1, 3, 2, 2, 4, 1 },
//    { 1, 1, 2, 2, 2, 1, 0 },
//    { 1, 1, 2, 1, 0, 0, 0 },
//};

var _genomeMap = new Dictionary<char, int>()
{
    { 'A', 1 },
    { 'C', 2 },
    { 'G', 3 },
    { 'T', 4 },
};

Console.WriteLine($"[{string.Join(", ", FindMinValuesInRanges("CAGCCTA", [2, 5, 0], [4, 5, 6]))}]"); // [2, 4, 1]

int[] FindMinValuesInRanges(string S, int[] P, int[] Q)
{
    var ints = new int[S.Length];
    for (int i = 0; i < S.Length; i++)
        ints[i] = _genomeMap[S[i]];

    var table = new SparseTableMin(ints);

    var answers = new int[P.Length];
    for (int i = 0; i < P.Length; i++)
        answers[i] = table.GetMinValue(P[i], Q[i]);

    return answers;
}
