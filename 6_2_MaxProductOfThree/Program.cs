// https://app.codility.com/demo/results/training6QS2NH-TDP/

Console.WriteLine(GetMaxProductOfThree([-3, 1, 2, -2, 5, 6]));

// Get max product (of multiplication) of any three elements in A.
// Hint! Find three largest positive values and two smallest negative, except 0.
//       Negatives are tracked because two multiplied negatives give a positive.
//       Compare a product of two negatives and the largest positive
//       with a product of all positives and return the larger product.
static int GetMaxProductOfThree(int[] A)
{
    int posHi, posMd, posLo = posMd = posHi = int.MinValue;
    int negLo, negHi = negLo = int.MaxValue;

    for (int i = 0; i < A.Length; i++)
    {
        var value = A[i];
        if (value > posHi)
        {
            posLo = posMd;
            posMd = posHi;
            posHi = value;
        }
        else if (value > posMd)
        {
            posLo = posMd;
            posMd = value;
        }
        else if (value > posLo)
        {
            posLo = value;
        }

        if (value < negLo)
        {
            negHi = negLo;
            negLo = value;
        }
        else if (value < negHi)
        {
            negHi = value;
        }

    }

    return Math.Max(
        negLo * negHi * posHi,
        posHi * posMd * posLo);
}
