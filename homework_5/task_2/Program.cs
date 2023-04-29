void FillArray(int[] numbers, int minValue, int maxValue)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(minValue, maxValue);
    }
}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

int Summa(int[] summa)
{   
    int count = 0;
    for (int i = 1; i < summa.Length; i++)
    {
    {
        if (i % 2 != 0) count += summa[i];
    }
    }
    return count;
}

void Task2()
{
    int size = 6;
    int[] numbers = new int[size];
    FillArray(numbers, 2, 4);
    PrintArray(numbers);
    Console.WriteLine($"Сумма элементов с нечетными индексамми равна {Summa(numbers)}");
}

Task2();
