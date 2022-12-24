// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArrayAndFilling(int N)
{
    int[] mass = new int [N];
    string str;
    for(int i = 0; i < mass.Length; i++)
    {
        str = "Введите длину " + (i + 1).ToString() + " стороны треугольника: ";
        mass[i] = GetNumber(str);
    }
    return mass;
}

bool Validate(int[] mass)
{
    bool f = true;
    if(mass.Length == 3)
    {
        f = f && mass[0] < mass[1] + mass[2];
        f = f && mass[1] < mass[0] + mass[2];
        f = f && mass[2] < mass[1] + mass[0];
    }
    else
    {
        f = false;
    }
    return f;
}

const int SIZE = 3;

void main()
{
    String s = String.Empty;
    do
    { 
        int[] arr = CreateArrayAndFilling(SIZE);
        if(Validate(arr))
        {
            Console.Write("Yes");
        }
        else
        {
            Console.Write("No");
        }
        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    }while(s != "y");

}

main();