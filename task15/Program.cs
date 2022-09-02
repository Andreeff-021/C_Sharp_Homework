// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 8 && number > 0)
{
    if (number == 6 || number == 7) Console.WriteLine("Этот день выходной!");
    else {Console.WriteLine("Это будний день");}
}
else
{
    Console.WriteLine("Введите число, соответствующее дню недели");
}