// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string ConversionToBinary(int N)
{
    string str = string.Empty;
    do
    {
        str = (N%2).ToString() + str;
        N = N /1;
    } while (N > 0);
    return str;
}