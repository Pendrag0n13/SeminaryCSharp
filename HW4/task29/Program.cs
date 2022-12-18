// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetNumber()
{
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int N)
{
    int[] mass = new int[N];    
}

int[] FillingArray(int mass[])
{
    for(int i = 0; i < mass.Length; i++)
    {
        mass[i] = GetNumber();
    }

    return mass;
}