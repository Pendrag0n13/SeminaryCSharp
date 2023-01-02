// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

const int SIZE_N = 5;
const int SIZE_M = 5;
const int LEFTRANGE = -99;
const int RIGHTRANGE = 99;

int[,] CreateArrayMxN(int M, int N, int leftRange, int rightRange)
{
    var rand = new Random();
    int[,] mass = new int [M, N];
    for(int i = 0; i < M; i++)
    {
        for(int j = 0; j < N; j++)
        {
            mass[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return mass;
}