Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[number.ToString().Length];
for (int i = 0; i < array.Length; i++)
    {
        array[i] = number % 10;
        number = number / 10;
    }
Array.Reverse(array);

if(array.Length<3)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(string.Join(" ", array[2]));
};