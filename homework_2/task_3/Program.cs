Console.Write("Введите порядковый номер дня недели: ");
int number = int.Parse(Console.ReadLine());
if(number==6||number==7)
{
    Console.Write("Выходной!");
}
else
{
    Console.Write("Работать!");
};