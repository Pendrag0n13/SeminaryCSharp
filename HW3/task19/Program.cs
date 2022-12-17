/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

String s = String.Empty;
do
{
    Console.Write("Введите пятизначное число: ");
    String inputStr = String.Empty;
    inputStr = Console.ReadLine();
    int number = Convert.ToInt32(inputStr);
    Console.WriteLine();
    int[] numberArr = new int[5];
    if((number > 9999) && (number < 100000))
    {
        for(int i = 0; i < 5; i++)
        {
            numberArr[i] = Convert.ToInt32(inputStr[i]);
        }
        if (numberArr[0] == numberArr[4] && numberArr[1] == numberArr[3])
        {
            Console.WriteLine($"{number} - Палиндром");
        }
        else
        {
            Console.WriteLine($"{number} - НЕ палиндром");
        }
    }
    else
    {
        Console.WriteLine("Ведено не пятизначное число!");
    }
    Console.WriteLine();
    Console.WriteLine("Завершить программу y/n ?");
    s = Console.ReadLine();
}while(s != "y");