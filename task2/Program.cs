int numberi = ReadNumber("Введите номер строки искомого элемента ");
int numberj = ReadNumber("Введите номер столбца искомого элемента ");

int [,] numbers = new int [20,20];
GetRandomArray(numbers);
Console.WriteLine(TwoDimensionArrayToString(numbers));

if (numberi > numbers.GetLength(0) || numberj > numbers.GetLength(1))
{
    Console.WriteLine("К сожалению, элемент с данными индексами отсутсвует");
}
else
{
    Console.WriteLine($"Значение элемента {numberi} строки и {numberj} столбца равно {numbers[numberi-1,numberj-1]}");
}


int ReadNumber(string message)
{
    Console.Write(message);
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.WriteLine("Вы ввели число неправильно, попробуйте еще раз");
    }
    return n;
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
