// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

