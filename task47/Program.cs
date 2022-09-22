// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetMatrix(int rowsCount, int colomnsCount, int leftRange = -10, int rightRange = 10)
{
    double[,] matrix = new double[rowsCount, colomnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1) + rand.NextDouble();
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{Math.Round((matrix[i, j]), 2)} ");
        }
        Console.WriteLine();
    }
}

int m = ReadNumber("Введите кол-во строк: ");
int n = ReadNumber("Введите кол-во столбцов: ");
double[,] matr = GetMatrix(m, n);
PrintMatrix(matr);