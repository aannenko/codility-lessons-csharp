// https://app.codility.com/demo/results/trainingBNKAKF-2D3/
// https://app.codility.com/demo/results/training9Z6653-6GZ/ chars instead of ints

using GenomicRangeQuery;

// S = genomic range consisting of letters A, C, G and T
// letters A, C, G and T have significance of 1, 2, 3 and 4 correspondingly
// P and Q = arrays with indices, between which we need to find min values in the genomic range S
// E.g. for S = "CAGCCTA", P[0] = 2 and Q[0] = 4 the min value is calculated from the slice GCC
// Return array of min significance for every range [P[i]..Q[i] + 1] (+ 1 because right index is exclusive)
var _genomeMap = new Dictionary<char, int>()
{
    { 'A', 1 },
    { 'C', 2 },
    { 'G', 3 },
    { 'T', 4 },
};

Console.WriteLine($"[{string.Join(", ", FindMinValuesInRanges("CAGCCTA", [2, 5, 0], [4, 5, 6]))}]"); // [2, 4, 1]
//int[,] sparseTableInThisCase =
//{
//    { 2, 1, 3, 2, 2, 4, 1 },
//    { 1, 1, 2, 2, 2, 1, 0 },
//    { 1, 1, 2, 1, 0, 0, 0 },
//};

int[] FindMinValuesInRanges(string S, int[] P, int[] Q)
{
    var ints = new int[S.Length];
    for (int i = 0; i < S.Length; i++)
        ints[i] = _genomeMap[S[i]];

    var table = new SparseTableMin(ints);
    //var table = new SparseTableMin<int>(ints); // optimized, incompatible with Codility

    var answers = new int[P.Length];
    for (int i = 0; i < P.Length; i++)
        answers[i] = table.GetMinValue(P[i], Q[i]);

    return answers;
}
