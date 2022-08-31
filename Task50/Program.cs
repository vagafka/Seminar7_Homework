// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такого числа в массиве нет

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
void FindElement (int[,] matrix, int a, int b)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        if (a==i && b==j)
        {
            Console.Write(matrix[i, j]);
        }
    }
}

Console.Write("Введите m и n через Enter "); 
int m = Convert.ToInt32(Console.ReadLine());//число строк
int n = Convert.ToInt32(Console.ReadLine());//число столбцов
Console.Write("Введите позиции элемента в двумерном массиве через Enter "); 
int a = Convert.ToInt32(Console.ReadLine());//строка
int b = Convert.ToInt32(Console.ReadLine());//столбец
int[,] matrix = FillMatrix(m, n);

if (a<0 || a>=matrix.GetLength(0) || b<0 || b>=matrix.GetLength(1))
{
 Console.WriteLine("Такого элемента в данном двумерном массиве нет");    
}


else
{
    PrintMatrix(matrix);
    Console.WriteLine("Значение искомого элемента - ");
    FindElement(matrix, a, b); 
}
