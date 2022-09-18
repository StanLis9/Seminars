// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Console.Clear();
Console.WriteLine();

decimal[] CreateArrayRndInt(int size, int min, int max)
{
    decimal[] array = new decimal[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(decimal[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

void Difference(decimal[] array)
{

    decimal min = array[0];
    decimal max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];


        if (array[i] > max)
            max = array[i];
    }
    Console.WriteLine(max-min);
}
decimal[] NewMassive = CreateArrayRndInt(5, 1, 2);
PrintArray(NewMassive);
Console.WriteLine();
Difference(NewMassive);
