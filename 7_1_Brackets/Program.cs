// https://app.codility.com/demo/results/trainingDQY677-3DZ/

Console.WriteLine(AreBracketsProperlyNested("{[()()]}")); // 1
Console.WriteLine(AreBracketsProperlyNested("([)()]")); // 0

// Check if all brackets have pairs and they are correctly nested.
static int AreBracketsProperlyNested(string S)
{
    var stack = new Stack<char>(S.Length);
    for (int i = 0; i < S.Length; i++)
    {
        var bracket = S[i];
        if (bracket == '(' || bracket == '{' || bracket == '[')
        {
            stack.Push(bracket);
            continue;
        }

        if (stack.Count == 0)
            return 0;

        var bracket2 = stack.Pop();
        if (bracket == ')' && bracket2 != '('
            || bracket == '}' && bracket2 != '{'
            || bracket == ']' && bracket2 != '[')
        {
            return 0;
        }
    }

    return stack.Count == 0 ? 1 : 0;
}