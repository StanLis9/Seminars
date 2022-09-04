// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();
Console.WriteLine("Привет пользователь, введи первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Отлично, продалжай, введи второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
int lub = num1 % num2;

if (num1 > num2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine($"{num1} кратно {num2}");
    }
    else
    {
        Console.WriteLine($"{num1} не кратен {num2}, остаток = {lub}");
    }
}
else
{
    Console.WriteLine("Введите другое ччисло");
}






Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int a1, int b1)
{
    return a1 % b1 == 0;
}

bool result = Multiplicity(a, b);

if (result) Console.WriteLine($"{a} Кратно {b}");
else Console.WriteLine($"{a} некратно {b} ; остаток от деления {a % b}");
