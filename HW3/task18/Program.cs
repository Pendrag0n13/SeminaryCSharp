/*
Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/
String s = String.Empty;
do
{
    Console.Write("Введите номер четверти: ");
    String inputStr = String.Empty;
    inputStr = Console.ReadLine();
    int chetvert = Convert.ToInt32(inputStr);
    if(chetvert == 1)
    {
        Console.WriteLine("x > 0; y > 0 ");
    }
    else if(chetvert == 2)
    {
        Console.WriteLine("x < 0; y > 0 ");
    }
    else if(chetvert == 3)
    {
        Console.WriteLine("x < 0; y < 0 ");
    }
    else if(chetvert == 4)
    {
        Console.WriteLine("x > 0; y < 0 ");
    }
    else
    {
        Console.WriteLine("Номер четверти введён некорректно");
    }
    Console.WriteLine();
    Console.WriteLine("Завершить программу y/n ?");
    s = Console.ReadLine();
}while(s != "y");