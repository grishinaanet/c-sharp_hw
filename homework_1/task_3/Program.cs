//Задача 6: Напишите программу, 
//которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно 
//на два без остатка).
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int residue = number % 2;
if(residue==0) 
{
    Console.Write("Четное");
}
else
{
    Console.Write("Нечетное");
};
