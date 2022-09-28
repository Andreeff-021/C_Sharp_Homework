// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumtMtoN(int m, int n)
{
    if (m < n)
    {
        if (n == m) return m;
        else return n + SumtMtoN(m, n - 1);
    }
    else
    {
        if (n == m) return n;
        else return m + SumtMtoN(m - 1, n);
    }
}
int m = ReadNumber("Введите M: ");
int n = ReadNumber("Введите N: ");
Console.WriteLine(SumtMtoN(m, n));

