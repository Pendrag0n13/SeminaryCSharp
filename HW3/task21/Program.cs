/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
String s = String.Empty;
do
{
    Console.WriteLine("Введите координаты точки A: ");
    Console.Write("x = ");
    int Ax = Convert.ToInt32(Console.ReadLine());
    Console.Write("y = ");
    int Ay = Convert.ToInt32(Console.ReadLine());
    Console.Write("z = ");
    int Az = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты точки B: ");
    Console.Write("x = ");
    int Bx = Convert.ToInt32(Console.ReadLine());
    Console.Write("y = ");
    int By = Convert.ToInt32(Console.ReadLine());
     Console.Write("z = ");
    int Bz = Convert.ToInt32(Console.ReadLine());
    //AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
    double res = Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2) + Math.Pow((Bz - Az), 2));
    Console.WriteLine($"{res:f7}");
    Console.WriteLine("Завершить программу y/n ?");
    s = Console.ReadLine();
}while(s != "y");