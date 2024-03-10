// https://app.codility.com/demo/results/trainingAST6DX-D5M/

Console.WriteLine(GetMinFrogJumps(10, 80, 30)); // 3

// A small frog wants to get to the other side of the road.
// X - frog's position
// Y - minimal target position
// D - frog's jump distance
// Count the minimal number of jumps that the small frog must perform to reach or pass its target.
static int GetMinFrogJumps(int X, int Y, int D)
{
    return (Y - X - 1 + D) / D;
}
