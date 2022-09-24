// Напишите программу которая будет преобразовывать десятичное число в двоичное.
// 45 ->  101101
// 3  ->  11
// 2  ->  10

Console.WriteLine("Введите целое число");
int num = default;
    while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.Write("Ошибка.\nВведите целое число: ");
    }


int ConvertToBynar(int num1)
{
    int count =1;
    int result = 0;
    while (num1 != 0)
    {
        
        result = (num1 % 2)*count+result;
        num1 = num1 / 2;
        count*= 10;

        
    }
    return result;
}
Console.WriteLine(ConvertToBynar(num));

