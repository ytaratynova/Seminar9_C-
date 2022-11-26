// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"

Console.WriteLine("Введите натуральное число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

if (n == 1) 
{
    Console.WriteLine($"Четных чисел в промежутке от {n} до 1 нет");
    return;
}

Console.WriteLine($"Четные числа в промежутке от {n} до 1:");
PrintNumbers(n);

void PrintNumbers(int number)
{
    if (number == 2) 
    {
        Console.Write(number);
        return;
    }
    else if (number % 2 == 0) 
    {
        Console.Write($"{number} ");
    }
    PrintNumbers(number - 1);
}