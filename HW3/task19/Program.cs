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
    Console.Write("Введите номер четверти: ");
    String inputStr = String.Empty;
    inputStr = Console.ReadLine();
    int number = Convert.ToInt32(inputStr);
    if((number > 9999) && (number < 100000))
    {
        
    }
    else
    {
        Console.WriteLine("Ведено не пятизначное число!");
    }
    Console.WriteLine();
    Console.WriteLine("Завершить программу y/n ?");
    s = Console.ReadLine();
}while(s != "y");