﻿// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] CreateArrayMxN(int rowCount, int colCount, int leftRange = 0, int rightRange = 9)
{
    Random rand = new Random();
    int[,] mass = new int[rowCount, colCount];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return mass;
}
