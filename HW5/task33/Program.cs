// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
int[] CreateArray(int N, int leftRange, int rightRange)
{
    var rand = new Random();
    int[] mass = new int [N];
    for(int i = 0; i < mass.Length; i++)
    {
        mass[i] = rand.Next(leftRange, rightRange + 1);
    }
    return mass;
}

bool PresentInArray(int[] mass, int number)
{
    for(int i = 0; i < mass.Length; i++)
    {
        if(mass[i] == number)
        {
            return true;
        }
    }
    return false;
}

const int SIZE = 4;
const int LEFTRANGE = -99;
const int RIGHTRANGE = 100; 

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
