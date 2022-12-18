// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

bool Validate(int number)//является ли число натуральным
{
    bool f = false;
    if(number > 0)
    {
        f = true;
    }
    return f;
}

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Calculation(int A, int B)//возводит число A в натуральную степень B
{
    int pow = A;
    for(int i = 2; i <= B; i++)
    {
        pow *= A;
    }
    return pow;
}

void main()
{
    String s = String.Empty;
    do
    { 
        int numberA = GetNumber("Введите число A: ");
        int numberB = GetNumber("Введите число B: ");
        if(Validate(numberB))
        {
            Console.WriteLine($"Число {numberA} в степени {numberB} = {Calculation(numberA, numberB)}");
        }
        else
        {
            Console.WriteLine($"Число {numberB} не является натуральным");
        }
        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    }while(s != "y");

}

main();