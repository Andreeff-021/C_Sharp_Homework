// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл 
// пользователь. Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int count = 0;

while(true)
{
    Console.Write("Введите число: ");
    var value = Console.ReadLine();
    if (int.TryParse(value, out int number))
    {
        if(number > 0) count++;
    }
    else if(value == "stop") break;
    else Console.WriteLine("Неверный ввод");
    
}
Console.WriteLine($"Введено {count} чисел больше нуля");