// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int SumDigit(int num)
{
    int sum = default;              //default = 0 - тоже самое 

    while (num > 0)
    {
        sum = sum + num%10; 
        num = num/10;
                                   // sum +=i 
    }
    return sum;
}

int result = SumDigit(number);
Console.WriteLine($"Сумма цифр в числе {number} = {result}");