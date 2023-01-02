﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.​
// 0,5 7 -2 -0,2 ​
// 1 -3,3 8 -9,9​
// 8 7,8 -7,1 9

double[,] CreateArrayMxN(int rowCount, int colCount, int leftRange = 0, int rightRange = 9)
{
    Random rand = new Random();
    double[,] mass = new double[rowCount, colCount];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = rand.NextDouble() * rightRange;
        }
    }
    return mass;
}