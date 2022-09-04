// 1. Напишите программу, которая на вход принимает два
// числа и выдает, какое число большее, а какое меньшее.
// a = 5, b = 10 -> max =7
// a = 2, b = 10 -> max =10
// a = -9, b = -3 -> max =-3



Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($" max = {num1} ");
}
if (num2 > num1)
{
    Console.WriteLine($" max = {num2} ");
}

