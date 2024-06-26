﻿// https://app.codility.com/demo/results/trainingMY9D9Y-HJW/

Console.WriteLine(GetIndexOfSliceWithMinAvg([4, 2, 2, 5, 1, 5, 8])); // 1
Console.WriteLine(GetIndexOfSliceWithMinAvg([4, 2, 2, 5, -4, 5, 8])); // 3
Console.WriteLine(GetIndexOfSliceWithMinAvg([-3, -5, -8, -4, -10])); // 2

// Find an index of a slice of A with a minimal average.
// Hint! Check only the slices of 2 and 3 items.
//       A slice longer than 3 items has its own slice of 2 or 3 items
//       with its average <= to the average of the original slice.
static int GetIndexOfSliceWithMinAvg(int[] A)
{
    var minAvg = decimal.MaxValue;
    var index = 0;
    for (var i = 0; i < A.Length - 2; i++)
    {
        var avg1 = (decimal)(A[i] + A[i + 1]) / 2;
        var avg2 = (decimal)(A[i] + A[i + 1] + A[i + 2]) / 3;
        var avg = Math.Min(avg1, avg2);
        if (avg < minAvg)
        {
            minAvg = avg;
            index = i;
        }
    }

    return (decimal)(A[A.Length - 2] + A[A.Length - 1]) / 2 < minAvg
        ? A.Length - 2
        : index;
}
