//Задача 4: Напишите программу, 
//которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
Console.Write("Введите 1е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2е число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3е число: ");
int c = Convert.ToInt32(Console.ReadLine());

int[] array = {0,1,2};
array[0]=a;
array[1]=b;
array[2]=c;

int n = array.Length;
int index=0;
int max=0;

while(n>index)
{
    if(array[index]>max)
    {
        max=array[index];
    }
    index++;
};

Console.Write("Максимальное число: "+max);
