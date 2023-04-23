//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[number.ToString().Length];
int sum = 0;
for (int i = 0; i < array.Length; i++)
    {
        array[i] = number % 10;
        sum=sum+array[i];
        number = number / 10;
    }
Array.Reverse(array);
Console.WriteLine(sum);