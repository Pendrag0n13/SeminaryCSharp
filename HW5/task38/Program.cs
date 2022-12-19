// Задача 38: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
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

(int, int) MaxAndMinElements(int[] mass)
{
    int max = mass[0];
    int min = mass[0];
    for(int i = 0; i < mass.Length; i++)
    {
        if(mass[i] > max)
        {
            max = mass[i];
        }
        if(mass[i] < min)
        {
            min = mass[i];
        }
    }
    return (min, max);
}

const int SIZE = 5;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 20; 