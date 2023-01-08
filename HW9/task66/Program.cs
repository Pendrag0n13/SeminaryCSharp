// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

(int, int) MinMax(int N1, int N2)
{
    if (N1 > N2)
    {
        return (N2, N1);
    }
    else
    {
        return (N1, N2);
    }
}

int SumNatureNumber(int min, int max)
{
    if (max == min)
    {
        return max;
    }
    return min + SumNatureNumber(min + 1, max);
}
int M = GetNumber("Введите M: ");
int N = GetNumber("Введите N: ");
(int min, int max) tmp = MinMax(M, N);
Console.Write($"M = {M}, N = {N} —> ");
Console.WriteLine($"{SumNatureNumber(tmp.min, tmp.max)} ");