// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

int[] SortRow(int[] array)
{
    int t;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                t = array[j + 1];
                array[j + 1] = array[j];
                array[j] = t;
            }
        }
    }
    return array;
}

int[] ArrayGetRow(int[,] matrix, int rowNumber)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = matrix[rowNumber, i];
    }
    return array;
}

bool ArraySetRow(int[] array, int[,] matrix, int rowNumber)
{
    if (array.Length == matrix.GetLength(0))
    {
        for (int i = 0; i < array.Length; i++)
        {
            matrix[rowNumber, i] = array[i];
        }
        return true;
    }
    return false;
}

void SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        ArraySetRow(SortRow(ArrayGetRow(matrix, i)),matrix, i);
    }
}
