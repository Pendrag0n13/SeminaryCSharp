// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка
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

int[] ArrayGetRow(int[,] matrix, int rowNumber)
{
    int[] array = new int[matrix.GetLength(1)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = matrix[rowNumber, i];
    }
    return array;
}

bool ArraySetRow(int[] array, int[,] matrix, int rowNumber)
{
    if (array.Length == matrix.GetLength(1))
    {
        for (int i = 0; i < array.Length; i++)
        {
            matrix[rowNumber, i] = array[i];
        }
        return true;
    }
    return false;
}

int SumRow(int[] arrayy)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
}
