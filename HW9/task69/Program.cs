// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Multy(int A, int B)
{
    if(B > 0)
    {
        return A * Multy(A, B - 1);
    }
    return 1;
}

int A = GetNumber("Введите A: ");
int B = GetNumber("Введите B: ");

Console.Write($"A = {A}, B = {B} —> ");
Console.WriteLine($"{Multy( A,  B)} ");
