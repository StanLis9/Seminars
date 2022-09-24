// Написать программу которая принимает на вход три числа
// и выдает может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треуг. - каждая сторона треуг. меньше суммы двух других

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num2 + num1) 
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("Не может");
}
