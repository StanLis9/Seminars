// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// Console.Clear();
// int number = new Random().Next(10, 1000);
// int firstDigit = number / 100;                                        Решение 1
// int secondDigit = number % 10;
// Console.WriteLine($"число {number} = {firstDigit} , {secondDigit}");    

// Решение 2
// int number = new Random().Next(100, 1000);                             
// Console.WriteLine(number);

// int num1 = number / 100;
// int num2 = number % 10;

// int result = num1 * 10 + num2;
// Console.WriteLine($"Число без средней цифры равно {result}");


int number = new Random().Next(100, 1000);

int MaxDigit(int num)
{
    int firstDigit = num / 100 * 10;
    int secondDigit = num % 10;    
    return firstDigit + secondDigit;
}
int result = MaxDigit(number);
Console.WriteLine($"{number} -> {result}");
