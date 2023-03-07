// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Пример1: 2, 3, 7 -> 7
// Пример1: 44 5 78 -> 78
// Пример1: 22 3 9 -> 22

Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ое число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max)
{
  max = b;
}
if (c > max)
{
  max = c;
}
Console.WriteLine("Максимальное число = " + max);

