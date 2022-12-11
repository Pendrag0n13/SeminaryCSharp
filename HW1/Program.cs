Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.");
Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.");
Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).");
Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.Write("Введите номер задачи(2, 4, 6, 8): ");
int TaskNumber = Convert.ToInt32(Console.ReadLine());
// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9
if(TaskNumber == 2)
{
    Console.Write("Введите первое число: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    if(firstNumber < secondNumber)
    {
        Console.Write("max = {0}, min = 2{1}", secondNumber, firstNumber);
    }
    else
    {
        Console.Write("max = {0}, min = {1}", firstNumber, secondNumber);
    }
}

// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
if(TaskNumber == 4)
{
    Console.Write("Введите число a: ");
    int NumberA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число b : ");
    int NumberB = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число c: ");
    int NumberC = Convert.ToInt32(Console.ReadLine());
    int max = Math.Max(Math.Max(NumberA, NumberB), NumberC);
    Console.Write("Максимальное число = {0}", max);
}
// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
if(TaskNumber == 6)
{
    Console.Write("Введите число: ");
    int NumberA = Convert.ToInt32(Console.ReadLine());
    if(NumberA % 2 == 0)
    {
        Console.Write("Число чётное");
    }
    else
    {
        Console.Write("Число нечётное");
    }    
}
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
if(TaskNumber == 8)
{
    Console.Write("Введите число N: ");
    int NumberN = Convert.ToInt32(Console.ReadLine());
    Console.Write("Чётный числа от 1 до {0}:", NumberN);
    for(int i = 1; i <= NumberN; i++)
    {
        if(i % 2 == 0)
        {
            Console.Write(" {0}", i);
        }
    }  
}