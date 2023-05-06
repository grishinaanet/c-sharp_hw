int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
    int[,] array = new int[firstLength, secondLength];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);

    return array;
}

void arithmeticMean(int[,] array)
{

    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sumColumn = 0;
        for (int j = 0; j < array.GetLength(0); j++)
            {
            // sumColumn = sumColumn + index(array[0, 1])
            sumColumn += array[j, i];
            }
        Console.WriteLine($"среднее арифметическое столбеца {i + 1} - {sumColumn / array.GetLength(0)} ");
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateTwoDimensionArray(line, column);
PrintArray(array);
Console.WriteLine("");
arithmeticMean(array);