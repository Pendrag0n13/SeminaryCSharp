// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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
        int[] arr = CreateArray(SIZE, LEFTRANGE, RIGHTRANGE);
        Console.Write($"[{string.Join(",", arr)}] -> ");
        
        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    }while(s != "y");

}

main();