// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

const int SIZE = 5;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 100; 

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

void main()
{
    String s = String.Empty;
    do
    { 
        int[] arr = CreateArray(SIZE, LEFTRANGE, rightRange);
        
        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    }while(s != "y");

}

main();