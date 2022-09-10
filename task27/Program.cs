// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigitNumber(int number)
{
    int temp = 0;
    int sum = 0;
    while(number > 0)
    {
        temp = number % 10;
        number = number / 10;
        sum = sum + temp;
    }
    return sum;
}

int number1 = ReadNumber("Введите число: ");
int sum1 = SumDigitNumber(number1);
Console.WriteLine($"Сумма цифр числа {number1} равна {sum1}");