// https://app.codility.com/demo/results/trainingFKMDH2-RX7/

Console.WriteLine(CountAliveFish([4, 3, 2, 1, 5], [0, 1, 0, 0, 0])); // 2

// Array A is array of fish. Array B denotes the direction each fish is flowing.
// A[i] is the size of a fish "i". Each fish has distinct size.
// The fish "i" flows upstream if B[i] is 0, otherwise 1.
// If two fish meet while moving in opposite directions - only the larger one survives.
// The one that survived keeps flowing in its direction.
// Calculate the number of fish that will stay alive.
static int CountAliveFish(int[] A, int[] B)
{
    int survived = A.Length;
    var downstream = new Stack<int>(A.Length);

    for (int i = 0; i < A.Length; i++)
    {
        if (B[i] == 1)
        {
            downstream.Push(A[i]);
            continue;
        }

        while (downstream.Count > 0)
        {
            survived--;
            if (downstream.Peek() < A[i])
                downstream.Pop();
            else
                break;
        }
    }

    return survived;
}
