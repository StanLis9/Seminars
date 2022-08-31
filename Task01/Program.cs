// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


Console.Clear();
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int square = num2 * num2;
if (square == num)
{
    Console.WriteLine($"Первое число {num} является квадратом {num2}");
}
else
{
    Console.WriteLine("Не является");
}










           




