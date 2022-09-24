﻿// Не используя реурсию вывести первые N чисел Фибоначчи.
// 5-> 01123
// 3 -> 011
// 7-> 0112358

Console.WriteLine("Введите число");

int num = Convert.ToInt32(Console.ReadLine());

int[] Fibonachhi(int number)
{
    int[] array = new int[number];
    array[0]=0;
    array[1]=1;
    for (int i = 2; i < number; i++)
    {
        array[i] = array[i-1] + array[i-2]; 
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}    
int[] arr = Fibonachhi(num);
PrintArray(arr);
