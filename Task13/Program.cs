// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Я понимаю что я сделал не правильно) помогите мне пожалуйста, мне очень тяжело в это вникнуть!

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// while (num >= 100 && num <= 1000)
// {

//     Console.WriteLine(num % 10);

//     break;

// }
// if (num >= 1000)
// {
//     num /= 10;
//     Console.WriteLine(num % 10);

// }
// else if (num >= 10000)
// {
//     num /= 100;
//     Console.WriteLine(num % 10 );
// }
// else if (num < 100)
// {
//     Console.WriteLine("Третьей цифры нет");

// }





// Подскажите как правильно ее решать??? 


while (num > 100 && num < 1000)
{
    Console.WriteLine(num % 10);
    break;
}
    if (num > 1000)
    {
        int num2 = num / 10;
    
        while (num2 > 100 && num2 <= 1000)
        {
        Console.WriteLine(num2 % 10);
        break;
        }
    }   
    if (num > 10000)
    {
        int num3 = num / 100;
    
        while (num3 > 100 && num3 <= 1000)
        {
        Console.WriteLine(num3 % 10);
        break;
        }
    } 
    if (num > 100000)
    {
        int num4 = num / 1000;
    
        while (num4 > 100 && num4 <= 1000)
        {
        Console.WriteLine(num4 % 10);
        break;
        }
    }
else if (num<100)
{
         Console.WriteLine("Нет третьего числа");
}
// else
// {
//     Console.WriteLine("Неверно");
// }