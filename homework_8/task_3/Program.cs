﻿int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
    int[,] array = new int[firstLength, secondLength];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);

    return array;
}

int[,] CreateTwoDimensionArray_2(int firstLength, int secondLength)
{
    int[,] array = new int[firstLength, secondLength];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);

    return array;
}

void CompositionTwoMatrix(int[,] first_array, int[,] second_array)
{
    int[,] third_array = new int[first_array.GetLength(0), second_array.GetLength(1)];
    for (int i = 0; i < first_array.GetLength(0); i++)
    {
        for (int j = 0; j < second_array.GetLength(1); j++)
        {
            for (int k = 0; k < second_array.GetLength(1); k++)
            {
                third_array[i, j] += first_array[i, k] * second_array[k, j];   
            } 
        System.Console.Write($"{third_array[i, j]} ");      
        }  
    System.Console.WriteLine(" ");    
    }
    
}

void PrintArray(int[,] first_array, int[,] second_array)
{
    for (int i = 0; i < first_array.GetLength(0); i++)
    {
        for (int j = 0; j < first_array.GetLength(1); j++)
            Console.Write($"{first_array[i, j]} ");
        Console.Write("| ");
        for (int j = 0; j < second_array.GetLength(1); j++)
            Console.Write($"{second_array[i, j]} ");
        Console.WriteLine();
    }
}
int[,] first_array = CreateTwoDimensionArray(2, 2);
int[,] second_array = CreateTwoDimensionArray_2(2, 2);
PrintArray(first_array, second_array);
CompositionTwoMatrix(first_array, second_array);