void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

void FillArrayKeyboard(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"Введите {i + 1} число ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int numbersPositiv(int[] num)
{   
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0)
        {
            count++;
        }
    }
    return count;
}



void Task1()
{
    Console.Write($"Сколько вы хотите ввести чисел: ");
    int numbersSize = Convert.ToInt32(Console.ReadLine());
    int size = numbersSize;
    int[] numbers = new int[size];
    FillArrayKeyboard(numbers);
    Console.WriteLine("Массив");
    PrintArray(numbers);
    Console.WriteLine($"Положительных чисел = {numbersPositiv(numbers)}");
}
Task1();