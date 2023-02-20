int firstLength = ReadInt("количество строк");
int secondLength = ReadInt("количество столбцов");

double[,] array = CreateTwoDimensionArray(firstLength, secondLength);

Console.WriteLine(TwoDimensionArrayToString(array));

int ReadInt(string argument)
{
	Console.Write($"Введите {argument} массива: ");
	int result = 0;

	while (!int.TryParse(Console.ReadLine(), out result))
	{
		Console.WriteLine("Try again");
	}

	return result;
}

double[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
	double[,] result = new double[firstLength, secondLength];
	Random rnd = new Random();

	for (int i = 0; i < result.GetLength(0); i++)
	{
		for (int j = 0; j < result.GetLength(1); j++)
		{
			result[i, j] = Math.Round(rnd.NextDouble() * 10, 2); // [0,1)
		}
	}

	return result;
}

string TwoDimensionArrayToString(double[,] array)
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
