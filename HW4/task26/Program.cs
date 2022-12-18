// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int countNumber(int N)
{
    int NFunc = Math.Abs(N);
    int count = 0;
    do
    {
        NFunc = NFunc / 10;
        count++;
    } while (NFunc > 0);
    return count;
}

