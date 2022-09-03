// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1000 && number > 99)
{
    int number2 = number / 10 % 10;
    Console.WriteLine(number2);
}
else
{
    Console.WriteLine("Введите трехзначное число!");
}