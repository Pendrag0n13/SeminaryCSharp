// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Factorial(int N)
{
    int mul = 1;
    for(int i = 1; i <= N; i++)
    {
        mul *= i;
    }
    return mul;
}

void main()
{
    String s = String.Empty;
    do
    { 
        int number = GetNumber("Введите число N: ");
        int multiply = Factorial(number);
        Console.WriteLine($"Произведение чисел от 1 до {number} = {multiply}");
        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    }while(s != "y");

}

main();