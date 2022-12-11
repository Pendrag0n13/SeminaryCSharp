Console.Write("Введите число a: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b : ");
int NumberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
int NumberC = Convert.ToInt32(Console.ReadLine());
int max = Math.Max(Math.Max(NumberA, NumberB), NumberC);
Console.Write("Максимальное число = {0}", max);