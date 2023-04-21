Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[number.ToString().Length];
for (int i = 0; i < array.Length; i++)
    {
        array[i] = number % 10;
        number = number / 10;
    }
Array.Reverse(array);
Console.WriteLine(string.Join(" ", array[1]));