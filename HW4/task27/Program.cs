// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumber(int number)//сумма цифр в числе
{
    int NFunc = Math.Abs(number);
    int sum = 0;
    while (NFunc > 0)
    {
        sum += NFunc % 10;
        NFunc = NFunc / 10;
    }
    return sum;
}

void main()
{
    String s = String.Empty;
    do
    { 
        int number = GetNumber("Введите число: ");
        Console.WriteLine($"Сумма цифр в числе {number} = {SumNumber(number)}");
        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    }while(s != "y");

}

main();