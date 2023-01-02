// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

int row;
int[,] triangle;
const int cellwidth = 2;

void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
}

void PrintTriangle()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] != 0)
            {
                Console.Write($"{triangle[i, j], cellwidth}");
            }
        }
        Console.WriteLine();
    }
}

void Magic()
{
    int col = cellwidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            Console.WriteLine(triangle[i, j]);
            col += cellwidth * 2;
        }
        col = cellwidth * row - cellwidth * (i + 1);
        Console.WriteLine();
    }
}

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void main()
{
    String s = String.Empty;
    do
    {
        Console.Clear();
        row = GetNumber("Введите число строк N треугольника Паскаля: ");
        triangle = new int[row, row];

        FillTriangle();
        Console.ReadLine();
        Magic();
        //PrintTriangle();
        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    } while (s != "y");
}

main();
