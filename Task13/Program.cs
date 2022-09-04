// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Console.Clear();
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());



// int num1 = num/10;
// int num2 = num1/10;
// int num3 = num2/10;
// int i = num;

// {
//     if (i <= num)

//         if (i >= 100 && i < 1000)
//         {
//             Console.WriteLine(num % 10);
//         }
//         else Console.WriteLine("Число не трехзначное");


// }

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


int num2 = num;
while (num2 <=num)
{
    if (num2 >=1000)
    {
        int num3 = num2/10;
    while (num3 >100 && num3>=1000)
    {
        Console.WriteLine(num3%10);
    }
    }
    Console.WriteLine(num2%10);
    break;
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





