// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

const int SIZE = 10;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 100;

int[] CreateArray(int N, int leftRange, int rightRange)
{
    var rand = new Random();
    int[] mass = new int[N];
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = rand.Next(leftRange, rightRange + 1);
    }
    return mass;
}

int[] CopyArray(int[] mass)
{
    int[] newMass = new int [mass.Length];
    for(int i = 0; i < mass.Length; i++)
    {
        newMass[i] = mass[i];
    }
    return newMass;
}

void main()
{
    String s = String.Empty;
    do
    {
        int[] arr1 = CreateArray(SIZE, LEFTRANGE, RIGHTRANGE);
        arr1[0] = -1000;
        Console.WriteLine($"[{string.Join(",", arr1)}]");

        int[] arr2 = CopyArray(arr1);
        arr1[0] = -5000;
        Console.WriteLine($"[{string.Join(",", arr2)}]");

        int[] arr3 = new int [arr1.Length];
        for(int i = 0; i < arr3.Length; i++)
        {
            arr3[i] = arr1[i];
        }
        arr1[0] = -8000;
        Console.WriteLine($"[{string.Join(",", arr3)}]");
        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    } while (s != "y");
}

main();
