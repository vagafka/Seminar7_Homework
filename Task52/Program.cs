// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] FillMatrix(int rowsCount, int columnsCount)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 10);

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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void ColumnAverage(int[,] matrix)
{
    double sum = 0;
    double aver = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)

        {
            sum = sum + matrix[i, j];

            //Console.Write(matrix[i, j]);
        }
        aver = sum / matrix.GetLength(0);
        Console.Write($"{Math.Round(aver,2)} ");
        sum = 0;

    }
}

Console.Write("Введите m и n через Enter ");
int m = Convert.ToInt32(Console.ReadLine());//число строк
int n = Convert.ToInt32(Console.ReadLine());//число столбцов

int[,] matrix = FillMatrix(m, n);



PrintMatrix(matrix);
Console.Write("Среднее арифметическое каждого столбца ");
ColumnAverage(matrix);
