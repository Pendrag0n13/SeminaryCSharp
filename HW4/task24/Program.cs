﻿// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

bool Validate(int number)//проверка, можно ли найти сумму для входящего числа
{
    if (number > 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int Sum1toA(int A) //нахождение суммы от 1 до А
{
    int sum = 0;
    for(int i = 1; i <= A; i++)
    {
        sum += i;
    }
}

int GetNumber(string message)
{
    Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

