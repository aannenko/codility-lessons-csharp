// https://app.codility.com/demo/results/trainingXPKT3C-PJM/

var result = CalculateCounters(5, [3, 4, 4, 6, 1, 4, 4]);
Console.WriteLine($"[{string.Join(", ", result)}]"); // [3, 2, 2, 4, 2]

// Calculate the values of counters after applying all operations on them
// N = number of counters
// array A holds operations to apply to the counters
// if A[i] <= N, raise the counter at position A[i]-1 by 1
// otherwise raise all counters to the value of the largest counter
// Return counters.

static int[] CalculateCounters(int N, int[] A)
{
    var counters = new int[N];
    var min = 0;
    var max = 0;
    for (int i = 0; i < A.Length; i++)
    {
        if (A[i] > N)
        {
            min = max;
            continue;
        }

        ref var counter = ref counters[A[i] - 1];
        if (counter < min)
            counter = min;

        counter++;
        if (max < counter)
            max = counter;
    }

    for (int i = 0; i < counters.Length; i++)
        if (counters[i] < min)
            counters[i] = min;

    return counters;
}