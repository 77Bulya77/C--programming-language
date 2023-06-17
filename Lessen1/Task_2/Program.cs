// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int max = 0;

System.Console.WriteLine("Введите первое число ");
int namber1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число ");
int namber2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите третье число ");
int namber3 = Convert.ToInt32(Console.ReadLine());

if (namber1 > max)
{
    max = namber1;
}
if (namber2 > max)
{
    max = namber2;
}
if (namber3 > max)
{
    max = namber3;
}

System.Console.WriteLine($"Максимальное число  {max}");