// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetNumber2()
{
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int N)
{
    int[] mass = new int[N];
    mass = FillingArray (mass);
    return mass; 
}

int[] FillingArray(int[] mass)
{
    for(int i = 0; i < mass.Length; i++)
    {
        mass[i] = GetNumber2();
    }

    return mass;
}

void main()
{
    String s = String.Empty;
    do
    { 
        int number = GetNumber("Введите размер мссива: ");
        Console.WriteLine("Заполните массив:");
        Console.WriteLine($"[{string.Join(", ", CreateArray(number))}]");
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    }while(s != "y");

}

main();