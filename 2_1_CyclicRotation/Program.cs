// https://app.codility.com/demo/results/training6GJHBM-TQ5/

Console.WriteLine(string.Join(' ', Rotate([1, 2, 3], 2)));
Console.WriteLine(string.Join(' ', Rotate([1, 2, 3], -5)));

// [1, 2, 3] => 2 = [2, 3, 1]
// [1, 2, 3] => -5 = [3, 1, 2]
static int[] Rotate(int[] A, int K)
{
    if (A.Length == 0 || K == 0 || K == A.Length)
        return A;

    var isRightShift = Math.Sign(K) > 0;
    var shift = Math.Abs(K) % A.Length;
    var buffer = new int[shift];
    if (isRightShift)
    {
        Array.Copy(A, A.Length - shift, buffer, 0, shift);
        Array.Copy(A, 0, A, shift, A.Length - shift);
        Array.Copy(buffer, A, shift);
    }
    else
    {
        Array.Copy(A, buffer, shift);
        Array.Copy(A, shift, A, 0, A.Length - shift);
        Array.Copy(buffer, 0, A, A.Length - shift, shift);
    }

    return A;
}