// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.Clear();
Console.WriteLine("Введите число А :");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B :");
int B = Convert.ToInt32(Console.ReadLine());


int Degree(int a1, int b1)
{

    if (a1 == 0)
    {
        return 0;
    }
    int count = a1;
    for (int i = 1; i < b1; i++)
    {
        a1 *= count;
    }
    return a1;
}
int result = Degree(A, B);
Console.WriteLine($"-> {result}");





















