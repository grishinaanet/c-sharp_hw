
﻿int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
    int[,] array = new int[firstLength, secondLength];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);

    return array;
}

void Sortirovka(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = array.GetLength(1) - 1; k > j; k--)
            {
                if (array[i, k] > array[i, k - 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k - 1];
                    array[i, k - 1] = temp;
                }
            }

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
int[,] array = CreateTwoDimensionArray(4, 4);
PrintArray(array);
Sortirovka(array);
Console.WriteLine("");
PrintArray(array);