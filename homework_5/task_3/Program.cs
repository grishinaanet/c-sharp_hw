void FillArray(double[] numbers, int minValue, int maxValue)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(minValue, maxValue) + rnd.NextDouble();
    }
}
void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

double MaxVal(double[] diff)
{
    double maxVal = diff[0];
    double maxIndex = 0;
    for (int i = 0; i < diff.Length; i++)
    {
        if (maxVal < diff[i]) 
        {
        maxVal = diff[i]; 
        maxIndex = i;
        }
    }
    return maxVal;
}

double MinVal(double[] diff)
{
    double minVal = diff[0];
    double minIndex = 0;
    for (int i = 0; i < diff.Length; i++)
    {
        if (minVal > diff[i]) 
        {
        minVal = diff[i]; 
        minIndex = i;
        }
    }
    return minVal;
}


void Task3()
{
    int size = 6;
    double[] numbers = new double[size];
    FillArray(numbers, 1, 2);
    PrintArray(numbers);
    Console.WriteLine($"Разница между максимальным и минимальным: {(MaxVal(numbers) - MinVal(numbers))}");
}

Task3();