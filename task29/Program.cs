// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = ReadNumber("Введите элемент массива: ");
}
Console.WriteLine(string.Join(" ", array));