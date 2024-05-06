// https://app.codility.com/demo/results/trainingNGDV6T-BWV/

Console.WriteLine(GetNumberOfWallBlocks([8, 8, 5, 7, 9, 8, 7, 4, 8]));

// Cover "Manhattan skyline" using the minimum number of rectangles.
// Each number in the array H is a portion of a wall
// with width 1, heigh H[i] and position "i" (leftmost "i" is 0).
// Two or more wall portions of the same hight may be built with one block.
// Portions [3, 4, 3] will need only two blocks to be built.
// Count minimum number of blocks to build the wall.
static int GetNumberOfWallBlocks(int[] H)
{
    var blockCount = 0;
    var stack = new Stack<int>(H.Length);
    for (int i = 0; i < H.Length; i++)
    {
        while (stack.Count > 0 && stack.Peek() > H[i])
            stack.Pop();

        if (stack.Count > 0 && stack.Peek() == H[i])
            continue;

        blockCount++;
        stack.Push(H[i]);
    }

    return blockCount;
}
