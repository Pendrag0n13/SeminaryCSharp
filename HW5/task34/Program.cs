// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int CoutEvenNumber(int[] mass)
{
    int count = 0;
    for(int i = 0; i < mass.Length; i++)
    {
        if(mass[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}