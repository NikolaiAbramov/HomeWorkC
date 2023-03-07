// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Пример 1: a = 5; b = 7 ->  max = 7
// Пример 2: a = 2 b = 10 -> max = 10
// Пример 3: a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
    Console.WriteLine($"max == {a}");
else
    Console.WriteLine($"max == {b}");