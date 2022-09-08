// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).
Console.Clear();

Console.WriteLine("Введите номер четверти (1-4)");
string quarter = Console.ReadLine();


string Quarter(string quart1)
{
    if (quart1 == "1") return "Первая четверть";
    if (quart1 == "2") return "Вторая четверть";
    if (quart1 == "3") return "Третья четверть";
    if (quart1 == "4") return "Четвертая четверть";
    return "Введен некорретный номер четверти";

}
string result = Quarter(quarter);
Console.WriteLine(result);