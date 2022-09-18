// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double b1 = ReadNumber("Введите значение B1: ");
double k1 = ReadNumber("Введите значение K1: ");
double b2 = ReadNumber("Введите значение B2: ");
double k2 = ReadNumber("Введите значение K2: ");

if (k1 == k2) Console.WriteLine("Прямые параллельны");
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * b2 - k2 * b1) / (k1 - k2);
    Console.WriteLine($"Прямые пересекаются в точке ({x}; {y})");
}