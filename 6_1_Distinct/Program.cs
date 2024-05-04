// https://app.codility.com/demo/results/trainingBPWQ9F-5T7/

Console.WriteLine(GetDistinctElementsCount([2, 1, 1, 2, 3, 1]));

// Count distinct elements
static int GetDistinctElementsCount(int[] A)
{
    return new HashSet<int>(A).Count;
}