// 1. Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел
// 2,3,7 -> max =7
// 44,5,78 -> max =78
// 22,3,9 -> max =22



Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max)  max = num2;
if (num3 > max)  max = num3;
Console.Write( $"max = {max}");

    

// Return Math.Max(num1, Math.Max(num2, num3));

