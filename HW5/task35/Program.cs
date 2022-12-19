﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
int[] CreateArray(int N, int leftRange, int rightRange)
{
    var rand = new Random();
    int[] mass = new int [N];
    for(int i = 0; i < mass.Length; i++)
    {
        mass[i] = rand.Next(leftRange, rightRange + 1);
    }
    return mass;
}

int CountElementsRange(int[] arary, int leftRange, int rightRange)
{
    int count = 0;
    for(int i = 0; i < arary.Length; i++)
    {
        if(arary >=  leftRange || arary <= rightRange)
        {
            count++;
        }
    }
    return count;
}

const int SIZE = 4;
const int LEFTRANGE1 = 0;
const int RIGHTRANGE1 = 151; 
const int LEFTRANGE2 = 10;
const int RIGHTRANGE2 = 100; 