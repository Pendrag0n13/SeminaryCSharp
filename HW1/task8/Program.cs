Console.Write("Введите число N: ");
int NumberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Чётный числа от 1 до {0}:", NumberN);
for(int i = 2; i <= NumberN; i += 2)
{
    Console.Write(" {0}", i);
} 