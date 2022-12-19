// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumUnevenElements(int[] mass)
{
    int sum = 0;
    for(int i = 1; i < mass.Length; i++)
    {
        if(i%2 != 0)
        {
            sum += mass[i];
        }
    }
    return sum;
}

const int SIZE = 5;
const int LEFTRANGE = -10;
const int RIGHTRANGE = 10; 

void main()
{
    String s = String.Empty;
    do
    { 
        int[] arr = CreateArray(SIZE, LEFTRANGE, RIGHTRANGE);
        Console.Write($"[{string.Join(",", arr)}] -> ");
        Console.Write(SumUnevenElements(arr));       
        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    }while(s != "y");

}

main();