// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] CreateArray0and1(int N)
{
    var rand = new Random();
    int[] mass = new int [N];
    for(int i = 0; i < N; i++)
    {
        mass[i] = rand.Next(0, 2);
    }
    return mass;
}

void main()
{
    String s = String.Empty;
    do
    {        
        int N = 8;   
        Console.WriteLine($"[{string.Join(", ", CreateArray0and1(N))}]");
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    }while(s != "y");

}

main();