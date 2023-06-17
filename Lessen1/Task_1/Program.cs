// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int max = 0;
int min = 0;

System.Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    max = a;
    min = b;
}
    
else
{
    max = b;
    min = a;
}

System.Console.WriteLine($"Максимальное число  {max} Минимальное число {min}");