int[,] array = new int[5,5];
GetRandomArray(array);
Console.WriteLine(TwoDimensionArrayToString(array));
Console.WriteLine();

for (int j = 0; j < array.GetLength(1); j++)
{
    double average = 0;
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        average = (average + array[i, j]);
        count++;
    }
    average = average / count;
    Console.Write(average + "; ");
}

void GetRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(0, 100);
            }   
        }
}

string TwoDimensionArrayToString(int[,] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			result += $"{array[i, j]} ";
		}

		result += Environment.NewLine;
	}

	return result;
}