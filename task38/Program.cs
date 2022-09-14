// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

int DifferenceMaxAndMinNumbers(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    int diff = max - min;
    return diff;
}

int[] array = GetArray(10, 1, 11);
Console.WriteLine(string.Join(", ", array));
int diffMaxMin = DifferenceMaxAndMinNumbers(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом = {diffMaxMin}");