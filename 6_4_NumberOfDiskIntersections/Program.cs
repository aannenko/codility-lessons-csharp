// https://app.codility.com/demo/results/trainingHECUUQ-29S/

Console.WriteLine(GetNumberOfDiskIntersections([1, 5, 2, 1, 4, 0])); // 11

// Given array A where A[i] is disk's radius and "i" is the center of that disk,
// find how many of these disks intersect with each other.
// Return -1 if the number of intersections is greater than 10 000 000.
static int GetNumberOfDiskIntersections(int[] A)
{
    var starts = new int[A.Length];
    var ends = new int[A.Length];

    int last = A.Length - 1;
    for (int center = 0; center < A.Length; center++)
    {
        var radius = A[center];
        int start = center > radius ? center - radius : 0;
        int end = last - center > radius ? center + radius : last;
        starts[start]++;
        ends[end]++;
    }

    var result = 0;
    int disksHere = 0;
    for (int center = 0; center < A.Length; center++)
    {
        if (starts[center] > 0)
        {
            result += disksHere * starts[center] + (starts[center] * (starts[center] - 1) / 2);

            if (result > 10_000_000)
                return -1;

            disksHere += starts[center];
        }

        disksHere -= ends[center];
    }

    return result;
}
