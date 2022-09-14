// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange);
    }
    return arr;
}
int SumOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}

int[] array = GetArray(10, 1, 11);
Console.WriteLine(string.Join(", ", array));
int sumOdd = SumOddPosition(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sumOdd}");