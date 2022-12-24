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
        str = "$\"Введите длину " + (i + 1).ToString() + " стороны треугольника: \"";
        mass[i] = GetNumber(str);
    }
    return mass;
}