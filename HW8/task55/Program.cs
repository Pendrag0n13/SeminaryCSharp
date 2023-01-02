// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] Replacement(int[,] matrix)
{
    int[,] temp = new int[matrix.GetLength(1), matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp[j, i] = matrix[i, j];
        }
    }

    return temp;
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
        Console.WriteLine();
        PrintMatrix(Replacement(arr));

        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    } while (s != "y");
}

main();
