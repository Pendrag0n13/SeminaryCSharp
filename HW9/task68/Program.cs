// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return A(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return A(m - 1, A(m, n - 1));
    }
    return 0;
}

int M = GetNumber("Введите m: ");
int N = GetNumber("Введите n: ");

Console.Write($"m = {M}, n = {N} —> A(m,n) = ");
Console.WriteLine($"{A(M, N)} ");