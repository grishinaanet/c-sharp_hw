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

int EvenNumbers(int[] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] % 2 == 0)
        {
            count++;
        }
   
    }
    return count;
}

void Task1()
{
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 999);
    PrintArray(numbers);
    Console.WriteLine($"Количество четных чисел равно {EvenNumbers(numbers)}");
}

Task1();
