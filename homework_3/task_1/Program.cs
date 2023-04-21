bool Palindrom(string arg)
{
    for (int i = 0; i < arg.Length / 2; i++)

        if (arg[i] != arg[arg.Length - i - 1])
            return false;
    return true;
}

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
string str = number.ToString();

if(Palindrom(str) == true)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("не Палиндром");
};
