// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");

if (m < n)
{
    Console.Write($"Сумма натуральных элементов в промежутке  от {m} до {n}: ");
    Console.Write(SumNumbers(m, n));
}
else
{
    Console.Write($"Сумма натуральных элементов в промежутке  от {n} до {m}: ");
    Console.Write(SumNumbers(n, m)); 
}

int SumNumbers(int minNumber, int maxNumber)
{
    if (minNumber == maxNumber) return maxNumber;
    else return minNumber + SumNumbers(minNumber + 1, maxNumber);
}
