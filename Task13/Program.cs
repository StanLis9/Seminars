// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Я понимаю что я сделал не правильно) помогите мне пожалуйста, мне очень тяжело в это вникнуть!

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num >=100 && num<=1000)
{
    
    Console.WriteLine(num%10);
    
    break;
    
}
if (num>=1000)                        
{
    num /=10;
    Console.WriteLine(num%10);
}
if (num <100)
{
    Console.WriteLine("Третьей цифры нет");
}
    
    

    
    

        

    






// while (n0<=num || n0>100 && n0<1000)
// {
//     Console.WriteLine(num%10);
//     n0=(n0+1)/10;
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 0;





