// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7) -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите первую координаты двух точек");
Console.Write("ax:");
double ax = Convert.ToDouble(Console.ReadLine());

Console.Write("ay:");
double ay = Convert.ToDouble(Console.ReadLine());

Console.Write("az:");
double az = Convert.ToDouble(Console.ReadLine());

Console.Write("bx:");
double bx = Convert.ToDouble(Console.ReadLine());

Console.Write("by:");
double by = Convert.ToDouble(Console.ReadLine());

Console.Write("bz:");
double bz = Convert.ToDouble(Console.ReadLine());


double Triple(double ax1, double ay1, double az1, double bx1, double by1, double bz1)
{
    return Math.Sqrt((bx1 - ax1) * (bx1 - ax1) + (by1 - ay1) * (by1 - ay1) + (bz - az) * (bz - az));

}
double result = Triple(ax, ay, az, bx, by, bz);
Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));