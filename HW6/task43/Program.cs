// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1;
double b2;
double k1;
double k2;

double GetX(double k1, double b1, double k2, double b2)
{
    return ((b2 - b1) / (k1 - k2));
}

double GetY(double k1, double b1, double k2, double b2)
{
    return ((k1 * b2 - k2 * b1) / (k1 - k2));
}

double GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

void main()
{
    String s = String.Empty;
    do
    {
        k1 = GetNumber("k1 = ");
        k2 = GetNumber("k2 = ");
        b1 = GetNumber("b1 = ");
        b2 = GetNumber("b2 = ");
        if (k1 != k2)
        {
            double dotX = GetX(k1, b1, k2, b2);
            double dotY = GetY(k1, b1, k2, b2);
            Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({dotX}; {dotY})");
        }
        else
        {
            Console.WriteLine($"k1 = k2 -> прямые параллельны");
        }
        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    } while (s != "y");
}

main();
