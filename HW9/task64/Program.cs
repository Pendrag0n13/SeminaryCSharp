// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NatureNumber(int Number, int itr = 1)
{
    if (itr < Number)
    {
        Console.Write($"{NatureNumber(Number, itr + 1)}, ");
    }
    return itr;
}

int N = GetNumber("Введите N: ");

Console.Write($"N = {N} —> ");
Console.WriteLine($"{NatureNumber(N)}");
