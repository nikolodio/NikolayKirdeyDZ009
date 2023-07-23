// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите стартовое число: ");
int numberStart = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число: ");
int numberEnd = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int start, int end)
{
    int result = start;
    if (start == end) return 0;
    start++;
    return result += SumNumbers(start , end);
}

Console.WriteLine($"Сумма числе от {numberStart} до {numberEnd} -> {SumNumbers(numberStart , numberEnd +1)}");