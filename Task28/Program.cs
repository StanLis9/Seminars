// // Задача 28: Напишите программу, которая
// // принимает на вход число N и выдаёт
// // произведение чисел от 1 до N.
// // 4 -> 24
// // 5 -> 120

Console.Clear();
Console.WriteLine("Введите натуральное число: ");
double number = Convert.ToInt32(Console.ReadLine());


double ProductOfNumber(double number1)
{
    int count = 1;
    for (int i = 1; i <= number; i++)
    {
        count*= i;
    }
    
       
    
    return count;
}

double result = ProductOfNumber(number);
Console.WriteLine($"Произведение числа от одного до числа {number} дает результат {result}");





















