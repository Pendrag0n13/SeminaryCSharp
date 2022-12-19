// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] MultyPara(int[] mass)
{
    int size = (mass.Length/2 + mass.Length%2);
    int[] result = new int[size];    
    for(int i = 0; i < size; i++)
    {
        result[i] = mass[i] * mass[mass.Length - 1 - i];
    }    
    if(mass.Length%2 != 0)
    {
        result[size-1] = mass[size-1];
    }
    return result;
}

const int SIZE = 5;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 10; 

void main()
{
    String s = String.Empty;
    do
    { 
        int[] arr = CreateArray(SIZE, LEFTRANGE, RIGHTRANGE);
        Console.Write($"[{string.Join(",", arr)}] -> ");
        Console.Write($"[{string.Join(",", MultyPara(arr))}]");       
        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    }while(s != "y");

}

main();