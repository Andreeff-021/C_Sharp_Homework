// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

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
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
            sum += matrix[i,j];
        }
        Console.Write($"    сумма {sum}");
        Console.WriteLine();
    }
}

void ComparesSumRows(int[,] matrix)
{
    int rowMinSum = 0;
    int minSumRow = 0;
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minSumRow += matrix[0, j];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            sum += matrix[i, j];
        }
        if (sum < minSumRow)
        {
            minSumRow = sum;
            rowMinSum = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Наименьшая сумма в строке {rowMinSum + 1}");
}

int m = ReadNumber("Введите кол-во строк: ");
int n = ReadNumber("Введите кол-во столбцов: ");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
ComparesSumRows(matr);