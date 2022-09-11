// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// заполненный псевдослучайными цифрами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
int[] arr = new int[8];

void newArr(int[] arr1)
{
    Random digit = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = digit.Next(0, 8);
    }
}
void PrintArray(int[] arr1)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr1[i]},");
        else
            Console.Write($"{arr1[i]}");
    }

    Console.Write("]");
}

newArr(arr);
PrintArray(arr);