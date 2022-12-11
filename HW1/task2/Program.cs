Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber < secondNumber)
{
    Console.Write("max = {0}, min = 2{1}", secondNumber, firstNumber);
}
else
{
    Console.Write("max = {0}, min = {1}", firstNumber, secondNumber);
}