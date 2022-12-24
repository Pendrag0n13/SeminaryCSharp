// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
void main()
{
    int n;
    int count = 0;
    string str = Console.ReadLine();
    while (str != "stop")
    {
        n = Convert.ToInt32(str);
        if (n > 0)
        {
            count++;
        }
        str = Console.ReadLine();
    }
    Console.WriteLine($"[{count}]");
}

main();
