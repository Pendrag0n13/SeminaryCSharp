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