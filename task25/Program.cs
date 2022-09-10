//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//  в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int PowerNumber(int a, int b)
{
    int pow = 1;
    for (int i = 0; i < b; i++)
    {
        pow = pow * a;
    }
    return pow;
}

int numberA = ReadNumber("Введите число A: ");
int numberB = ReadNumber("Введите возводимую степнь B: ");
int PowerNumberA = PowerNumber(numberA, numberB);
Console.WriteLine($"{numberA} в степени {numberB} равно {PowerNumberA}");