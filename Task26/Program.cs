// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Count(int num)
{
    if (num != 0)
    {
        if(num < 0) num = -num;
        int i = 0;
        while (num > 0)
        {
            num = num / 10;
            i++;
        }
        return i;
    }
    return 1;

}
int number = Count(num);
Console.WriteLine(number);

