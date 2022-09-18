// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num;
if (num < 100)
{
    Console.WriteLine("Неверное число");
}
else
{
    while (num2 > 999)
    {
        num2 = num2 / 10;
    }
    Console.WriteLine(num2 % 10);
}

// if (num < 100)
// {
//     Console.WriteLine("Нет третьего числа");
// }









// else
// {
//     Console.WriteLine("Неверно");
// }