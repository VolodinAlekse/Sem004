﻿// Задача 30: Напишите программу, 
// которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}
int[] FillArray()
{
    int[] arrN = new int[8];
    for (int i = 0; i < 8; i++)
    {
        arrN[i] = new Random().Next(0, 2);
    }
    return arrN;
}
int[] myarray = FillArray();

PrintArray(myarray);
