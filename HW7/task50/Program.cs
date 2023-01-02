// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

const int ROWSCOUNT = 5;
const int COLUMNSCOUNT = 5;

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

string SearchElement(int[,] matrix, int i, int j)
{
    string str = "—> числа с такой позицией в матрице нет";
    if (i <= matrix.GetLength(0) && j <= matrix.GetLength(1) && i > 0 && j > 0)
    {
        str = "—> " + matrix[i - 1, j - 1].ToString();
    }
    return str;
}

void main()
{
    String s = String.Empty;
    do
    {
        int[,] arr = CreateArrayMxN(ROWSCOUNT, COLUMNSCOUNT);
        int rows = GetNumber("Введите строку: ");
        int columns = GetNumber("Введите  столбец: ");
        Console.WriteLine();
        Console.WriteLine($"{rows} {columns} {SearchElement(arr, rows, columns)}");
        Console.WriteLine();
        PrintMatrix(arr);
        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    } while (s != "y");
}

main();
