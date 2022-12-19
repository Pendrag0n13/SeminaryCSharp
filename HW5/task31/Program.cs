// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

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

(int, int) GetSumPositiveAndNegative(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)//positive element
        {
            sumPositive += array[i];
        }
        else if(array[i] < 0)//negative element
        {
            sumNegative += array[i];   
        }
    }
    return (sumPositive, sumNegative);
}

const int SIZE = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

int arr = CreateArray(SIZE, LEFTRANGE, RIGHTRANGE);

Console.WriteLine(string.Join(",", arr));

int sumP;
int sumN;
(sumP, sumN) = GetSumPositiveAndNegative(arr);

Console.WriteLine($"Сумма положительных чисел = {sumP}, сумма отрицательных = {sumN}");