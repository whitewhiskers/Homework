﻿int[] FillArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-9, 10);
    }
    return array;
}
void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) System.Console.Write($"{arr[i]},");
        else System.Console.Write($"{arr[i]}");
    }
    System.Console.WriteLine("]");
}
int[] array = FillArray(12);
int sumPlus = 0;
int sumMinus = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0) sumMinus += array[i];
    else sumPlus += array[i];
}

PrintArray(array);
System.Console.WriteLine($"Сумма положительных чисел = {sumPlus}");
System.Console.WriteLine($"Сумма отрицательных чисел = {sumMinus}");