// // Задайте две матрицы. Напишите программу, 
// // которая будет находить произведение двух матриц.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void MultiplyMatrices(int[,] matrix1, int[,] matrix2, out int[,] result)
{
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);

    result = new int[rows1, cols2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            for (int k = 0; k < cols1; k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
}

Console.Clear();
Console.Write("Введите количество строк для первой матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для первой матрицы: ");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
Console.Write("Введите количество строк для второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для второй матрицы: ");
int cols2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array2 = new int[cols, rows2];
FillArray(array2);
PrintArray(array2);

int[,] product;
MultiplyMatrices(array, array2, out product);
Console.WriteLine("Произведение двух матриц:");
System.Console.WriteLine();
PrintArray(product);
