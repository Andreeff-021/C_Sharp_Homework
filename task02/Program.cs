// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA != numberB)
    if(numberA > numberB)
    {
        Console.WriteLine($"{numberA} > {numberB}");
    }
    else
    {
        Console.WriteLine($"{numberB} > {numberA}");
    }
else
{
    Console.WriteLine("Введите неравные числа!");
}