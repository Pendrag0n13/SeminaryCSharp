// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

(int, int) MinElement(int[,] matrix)
{
    int min = matrix[0, 0];
    int indexI = 0;
    int indexJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexI = i;
                indexJ = j;
            }
        }
    }
    return (indexI, indexJ);
}

int[,] DeleteCrossMinElement(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    var (indexI, indexJ) = MinElement(matrix);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < indexI && j < indexJ)
            {
                newMatrix[i, j] = matrix[i, j];
            }
            else if (i > indexI && j < indexJ)
            {
                newMatrix[i - 1, j] = matrix[i, j];
            }
            else if (i < indexI && j > indexJ)
            {
                newMatrix[i, j - 1] = matrix[i, j];
            }
            else if (i > indexI && j > indexJ)
            {
                newMatrix[i - 1, j - 1] = matrix[i, j];
            }
        }
    }
    return newMatrix;
}
