// https://app.codility.com/demo/results/trainingM4RBSW-6CR/

Console.WriteLine(AreParenthesesProperlyNested("(()(())())")); // 1
Console.WriteLine(AreParenthesesProperlyNested("())")); // 0

// Check if all parentheses have pairs and they are correctly nested.
// Note! Same as 7.1 Brackets but only with '(' and ')'.
// Hint! In contrast with 7.1 Brackets, we don't have to use Stack here.
static int AreParenthesesProperlyNested(string S)
{
    var unpairedLeft = 0;
    for (int i = 0; i < S.Length; i++)
    {
        if (S[i] == '(')
        {
            unpairedLeft++;
            continue;
        }

        if (unpairedLeft == 0)
            return 0;

        unpairedLeft--;
    }

    return unpairedLeft == 0 ? 1 : 0;
}