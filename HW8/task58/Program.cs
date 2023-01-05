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
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void MatrixMultiplication(int[,] A, int[,] B, int[,] C)
{
    int sum = 0;
    for (int i = 0; i < C.GetLength(0); i++)
    {
        for (int j = 0; j < C.GetLength(1); j++)
        {
            sum = 0;
            for (int k = 0; k < A.GetLength(1); k++)
            {
                sum += A[i, k] * B[k, j];
            }
            C[i, j] = sum;
        }
    }
}

bool ValidateMatrixMultiplication(int[,] A, int[,] B)
{
    if (A.GetLength(1) == B.GetLength(0))
    {
        return true;
    }
    return false;
}

int[,] MatrixProduct(int[,] A, int[,] B)
{
    int[,] C = new int[A.GetLength(0), B.GetLength(1)];
    if (ValidateMatrixMultiplication(A, B))
    {
        MatrixMultiplication(A, B, C);
    }
    return C;
}

void main()
{
    String s = String.Empty;
    do
    {
        Console.Clear();
        int rowsA = GetNumber("Введите число строк матрицы А: ");
        int columnsA = GetNumber("Введите число столбцов матрицы А: ");
        int[,] arrA = CreateArrayMxN(rowsA, columnsA);
        int rowsB = GetNumber("Введите число строк матрицы B: ");
        int columnsB = GetNumber("Введите число столбцов матрицы B: ");
        int[,] arrB = CreateArrayMxN(rowsB, columnsB);

        PrintMatrix(arrA);
        Console.WriteLine();
        PrintMatrix(arrB);
        Console.WriteLine();
        if(ValidateMatrixMultiplication(arrA, arrB))
        {
        PrintMatrix(MatrixProduct(arrA, arrB));
        }
        else
        {
            Console.WriteLine("Умножение матриц невозможно!");
        }

        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    } while (s != "y");
}

main();