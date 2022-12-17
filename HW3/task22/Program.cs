/*
Задача 22: Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4

Доп. задание
Написать метод для разворота массива, не используя память под дополнительный массив

*/
String s = String.Empty;
do
{    
    Console.Write("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    double[] res = new double[N];
    for(int i = 1; i <= N; i++)
    {
        res[i-1] = Math.Pow(i, 2);
        Console.Write($"{res[i-1]:f0} ");
    }
    Console.WriteLine();
    Console.WriteLine("Завершить программу y/n ?");
    s = Console.ReadLine();
}while(s != "y");
