// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string FibonacciN(int N)
{
    string str = string.Empty;
    if(N == 1)
    {
        str = "0"; 
    }
    else if (N == 2)
    {
        str = "0, 1"; 
    }
    else if (N > 2)
    {
        int[] mass = new int[N];
        mass[0] = 0;
        mass[1] = 1;
        str = "0, 1";
        for(int i = 2; i < N; i++)
        {
            mass[i] = mass[i-1] + mass[i-2];
            str = str + ", " + mass[i].ToString();
        }
    }
    else
    {
        str = "Введено некорректное число!";
    }
    return str; 
}

void main()
{
    String s = String.Empty;
    do
    { 
        int numberA = GetNumber("Введите число N: ");
        Console.WriteLine("Первые N чисел Фибоначчи: " + FibonacciN(numberA));
        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    }while(s != "y");

}

main();