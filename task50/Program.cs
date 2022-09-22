// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int colomnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, colomnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintSearchElement(int[,] matrix, int a, int b)
{
    if (a < matrix.GetLength(0) && b < matrix.GetLength(1))
    {
        Console.WriteLine($"Искомый элемент равен {matrix[a, b]}");
    }
    else Console.WriteLine("Такого элемента нет");
}

int m = ReadNumber("Введите кол-во строк: ");
int n = ReadNumber("Введите кол-во столбцов: ");
int a = ReadNumber("Введите строку искомого элемента ");
int b = ReadNumber("Введите столбец искомого элемента: ");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
PrintSearchElement(matr, a, b);