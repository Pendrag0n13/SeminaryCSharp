// Задача 67: Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int Number)
{
    if(Number/10 == 0)
    {
        return Number%10; 
    }
    return  Number%10 + Sum(Number/10);
}


int N = GetNumber("Введите N: ");
Console.Write($"N = {N} —> ");
Console.WriteLine($"{Sum(N)} ");
