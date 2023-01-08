// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

(int, int) MinMax(int N1, int N2)
{
    if(N1 > N2)
    {
        return (N2, N1);
    }
    else
    {
        return(N1, N2);
    }
}

