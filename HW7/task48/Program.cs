﻿// Задача 48: Задайте двумерный массив размера m на n, каждый элемент 
//в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateArrayMxN(int M, int N)
{
    int[,] mass = new int [M, N];
    for(int i = 0; i < mass.GetLength(0); i++)
    {
        for(int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = i + j;;
        }
    }
    return mass;
}