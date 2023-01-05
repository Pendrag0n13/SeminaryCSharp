// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] A, int[,] B)
{
    int[,] C = new int[A.GetLength(1), B.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < C.GetLength(0); i++)
    {
        for (int j = 0; j < C.GetLength(1); j++)
        {
            sum = 0;
            for (int k; k < A.GetLength(0); k++)
            {
                sum += A[i, k] * B[k, j];
            }
            C[i, j] = sum;
        }
    }
    return C;
}
