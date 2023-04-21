//Задача 8: Напишите программу, 
//которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = number/2;
int[] array= new int[index];
int residue = number%2;

if(residue!=0)
{
    number=number-1;
}

while(number!=0)
{
    array[index-1]=number;
    number=number-2;
    index=index-1;
};

var str =string.Join(" ", array);
Console.Write(str);
