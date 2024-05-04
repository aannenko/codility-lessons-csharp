// https://app.codility.com/demo/results/training677AXM-8CA/

Console.WriteLine(IsTriangleInArray([10, 2, 5, 1, 8, 20]));

// Array A contains lengths of sides of a potential triangle.
// Check if a triangle can actually be made of any three of them.
// Hint! Sort the array and check if any two adjacent sides
//       are longer toghether than the next side.
static int IsTriangleInArray(int[] A)
{
    if (A.Length < 3)
        return 0;

    Array.Sort(A);
    for (int i = 0; i < A.Length - 2; i++)
        if (A[i] > A[i + 2] - A[i + 1])
            return 1;

    return 0;
}