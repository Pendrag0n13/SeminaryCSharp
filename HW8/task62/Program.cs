// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] CreateArrayMxN(int rowCount, int colCount, int leftRange = 0, int rightRange = 9)
{
    Random rand = new Random();
    int[,] mass = new int[rowCount, colCount];
    int N = mass.GetLength(0);
    int M = mass.GetLength(1);
    int Ibeg = 0,
        Ifin = 0,
        Jbeg = 0,
        Jfin = 0;

    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= N * M)
    {
        mass[i, j] = k;
        if (i == Ibeg && j < M - Jfin - 1)
        {
            j++;
        }
        else if (j == M - Jfin - 1 && i < N - Ifin - 1)
        {
            i++;
        }
        else if (i == N - Ifin - 1 && j > Jbeg)
        {
            j--;
        }
        else
        {
            i--;
        }

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != M - Jfin - 1))
        {
            Ibeg++;
            Ifin++;
            Jbeg++;
            Jfin++;
        }
        k++;
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

void main()
{
    String s = String.Empty;
    do
    {
        Console.Clear();
        int rows = GetNumber("Введите число строк: ");
        int columns = GetNumber("Введите число столбцов: ");
        int[,] arr = CreateArrayMxN(rows, columns);
        Console.WriteLine();
        PrintMatrix(arr);

        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    } while (s != "y");
}

main();
