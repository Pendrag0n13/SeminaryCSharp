// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] CreateArrayXxYxZ(
    int CountX,
    int CountY,
    int CountZ,
    int leftRange = 10,
    int rightRange = 99
)
{
    int[,,] mass = new int[CountX, CountY, CountZ];
    int[] array = new int[CountX * CountY * CountZ];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int l = 0; l < mass.GetLength(2); l++)
            {
                mass[i, j, l] = SetNumber(array, leftRange, rightRange);
            }
        }
    }
    return mass;
}

bool Validate(int[] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (number == array[i])
        {
            return false;
        }
    }
    return true;
}

int SetNumber(int[] array, int leftRange, int rightRange)
{
    Random rand = new Random();
    int f;
    do
    {
        f = rand.Next(leftRange, rightRange + 1);
    } while (!Validate(array, f));
    return f;
}

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            {
                Console.Write($"{matrix[i, j, l]}({i}, {j}, {l}) \t");
            }
            Console.WriteLine();
        }
    }
}
void main()
{
    String s = String.Empty;
    do
    {
        Console.Clear();
        int X = GetNumber("Введите размерность по Х: ");
        int Y = GetNumber("Введите размерность по Y: ");
        int Z = GetNumber("Введите размерность по Z: ");
        int[,,] arr = CreateArrayXxYxZ(X, Y, Z);
        Console.WriteLine();
        PrintMatrix(arr);        
        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    } while (s != "y");
}

main();