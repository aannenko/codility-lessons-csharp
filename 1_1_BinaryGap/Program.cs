// https://app.codility.com/demo/results/training6M39ZR-UBE/

Console.WriteLine(GetLargestBinaryGap(1041)); // largest gap for 1041 (10000010001) is 5

static int GetLargestBinaryGap(int N)
{
    var gapStarted = false;
	var currentGap = 0;
	var largestGap = 0;
	for (int i = 0; i < 32; i++)
	{
		if ((N & 1 << i) != 0) // if bit is set, start new gap
		{
			if (gapStarted && currentGap > largestGap)
				largestGap = currentGap;

			gapStarted = true;
			currentGap = 0;
		}
		else if (gapStarted)
		{
			currentGap++;
		}
	}

	return largestGap;
}
