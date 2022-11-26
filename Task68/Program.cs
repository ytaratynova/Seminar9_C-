// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите неотрицательное число m: ");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите неотрицательное число n: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");

int Akkerman(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberN == 0) return Akkerman(numberM - 1, 1);
    else return Akkerman(numberM - 1, Akkerman (numberM, numberN - 1));


}