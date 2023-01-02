// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

const int SIZE_N = 4;
const int SIZE_M = 3;
const int LEFTRANGE = -99;
const int RIGHTRANGE = 99;

int[,] CreateArrayMxN(int M, int N, int leftRange = 0, int rightRange = 50)
{
    Random rand = new Random();
    int[,] mass = new int [M, N];
    for(int i = 0; i < mass.GetLength(0); i++)
    {
        for(int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return mass;
}

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

votd PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j], " ");
        }
        Console.WriteLine();
    }
}

