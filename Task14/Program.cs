// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Clear();
Console.WriteLine("Привет пользователь, введи число ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num7 = 7;
int num23 = 23;


if ((num1 % num7 == 0) && (num1 % num23 == 0))
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}


Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

bool square(int a1, int b1)
{
    return (a1 * a1 == b1 || b1 * b1 == a1);
}

bool result = square(a, b);

if (result) Console.WriteLine($"Правда");
else Console.WriteLine($"Ложь");
