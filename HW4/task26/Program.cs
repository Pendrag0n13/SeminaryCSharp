// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int CountNumber(int N)
{
    int NFunc = Math.Abs(N);
    int count = 0;
    do
    {
        NFunc = NFunc / 10;
        count++;
    } while (NFunc > 0);
    return count;
}

void main()
{
    String s = String.Empty;
    do
    { 
        int number = GetNumber("Введите число N: ");        
        int count = CountNumber(number);
        Console.WriteLine($"Количество цифр в числе {number} = {count}");

        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    }while(s != "y");

}

main();