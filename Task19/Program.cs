// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int digit = Convert.ToInt32(Console.ReadLine());
int num1 = digit / 10000;
int num2 = digit % 10;
int num3 = digit / 1000 % 10;
int num4 = digit /10 % 10;
if (digit > 9999 && digit < 100000)
{
    if (num1 == num2 && num3 == num4 )
    {
        Console.WriteLine($"{digit} -> да");
    }
    else
    {
        Console.WriteLine($"{digit} -> нет");
    }
}