// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
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

int CountElementsRange(int[] arary, int leftRange, int rightRange)
{
    int count = 0;
    for(int i = 0; i < arary.Length; i++)
    {
        if(arary[i] >=  leftRange && arary[i] <= rightRange)
        {
            count++;
        }
    }
    return count;
}

const int SIZE = 123; //размер массива
const int LEFTRANGE1 = 0;//левая граница диапазона случайных чисел при заполнении массива
const int RIGHTRANGE1 = 150;//правая граница диапазона случайных чисел при заполнении массива
const int LEFTRANGE2 = 10;//левая граница отрезка, в котором должны лежать числа
const int RIGHTRANGE2 = 100;//правая граница отрезка, в котором должны лежать  числа

void main()
{
    String s = String.Empty;
    do
    { 
        int[] arr = CreateArray(SIZE, LEFTRANGE1, RIGHTRANGE1);
        Console.Write($"[{string.Join(",", arr)}] -> ");
        Console.WriteLine(CountElementsRange(arr, LEFTRANGE2, RIGHTRANGE2));        
        Console.WriteLine();
        Console.WriteLine("Завершить программу y/n ?");
        s = Console.ReadLine();
    }while(s != "y");

}

main();