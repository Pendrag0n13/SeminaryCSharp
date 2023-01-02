// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.`

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

double[] AverageColumns(int[,] matrix)
{
    double[] avercol = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        avercol[j] = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            avercol[j] += matrix[i, j];
        }
        avercol[j] = avercol[j] / matrix.GetLength(0);
        avercol[j] = Math.Round(avercol[j], 2);
    }
    return avercol;
}

void main()
{
    String s = String.Empty;
    do
    {
        int rows = GetNumber("Введите число строк: ");
        int columns = GetNumber("Введите число столбцов: ");
        int[,] arr = CreateArrayMxN(rows, columns);
        PrintMatrix(arr);
        Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join(", ", AverageColumns(arr))}");
        
        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    } while (s != "y");
}

main();