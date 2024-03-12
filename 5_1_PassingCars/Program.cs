// https://app.codility.com/demo/results/trainingQNRVXJ-TDY/

Console.WriteLine(CountPassingCars([0, 1, 0, 1, 1])); // 5
Console.WriteLine(CountPassingCars([1, 0])); // 0

// A = array of 0s and 1s representing moving cars
// 0s are cars traveling east, 1s are going west
// Return a number of cars passing each other on their way
static int CountPassingCars(int[] A)
{
    var passed = 0;
    var willPass = 0;
    for (var i = 0; i < A.Length; i++)
    {
        if (A[i] == 0)
        {
            willPass++;
        }
        else
        {
            passed += willPass;
            if (passed > 1_000_000_000)
                return -1;
        }
    }

    return passed;
}