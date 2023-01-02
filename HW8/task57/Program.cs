// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9
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

int CountElement(int[,] matrix, int element)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (element == matrix[i, j])
            {
                count++;
            }
        }
    }
    return count;
}

int[,] Dictionary(int[,] matrix, int[] list)
{
    int[,] dict = new int[list.Length, 2];

    for (int k = 0; k < list.Length; k++)
    {
        dict[k, 0] = list[k];
        dict[k, 1] = CountElement(matrix, list[k]);
    }

    return dict;
}

int[] LIST = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

void PrintDictionary(int[,] dict)
{
    for (int k = 0; k < dict.GetLength(0); k++)
    {
        if (dict[k, 1] != 0)
        {
            Console.WriteLine($"{dict[k, 0]} встречается {dict[k, 1]} раз(а)");
        }
    }
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
        PrintDictionary(Dictionary(arr, LIST));
        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    } while (s != "y");
}

main();
